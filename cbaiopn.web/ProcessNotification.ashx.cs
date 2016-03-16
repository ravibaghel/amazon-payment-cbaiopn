using System;
using System.Web;
using System.Web.UI;
using cbaiopn.infrastructure.processor;
using cbaiopn.core.common;
using cbaiopn.core;
using System.Web.Configuration;
using Serilog;
using cbaiopn.core.Exceptions;
using System.Web.Query.Dynamic;
using System.Text;

namespace cbaiopn.web
{
	
	public class ProcessNotification : System.Web.IHttpHandler
	{
	
		ILogger log = new LoggerConfiguration()
			.WriteTo.File("log.txt")
			.CreateLogger();
		public void ProcessRequest (HttpContext context)
		{
			log.Information("Starting post...");
			//Clear the response (just in case)
			ClearResponse(context);
			//check only post
			if (context.Request.HttpMethod.ToUpper () == "POST") {
				try {
					// Authenticate the request using UUID, Timestamp and Signature
					AuthenticateRequest(context.Request);
				}catch (CBAIOPNClientException exception) {
					log.Error (exception.Message);
					SetResponse (context, 400, exception.Message);
					return;
				} 
				catch (CBAIOPNException exception) {
					log.Error (exception.Message);
					SetResponse (context, 403, "Authentication failed");
					return;
				}

				try {
					Process(context.Request);
					SetResponse(context,200,"success");
					return;
				} catch (CBAIOPNException exception) {
					SetResponse (context, 500, exception.Message);
					return;
				}

			} else {
				context.Response.Headers.Add("Allow", "POST");
				SetResponse (context, 405, "Only POST method allowed");
				return;
			}


		}

		protected void AuthenticateRequest(HttpRequest request)
		{
			log.Information("Authenticating the Request...");
			String awsAccessKeyId = request["AWSAccessKeyId"];
			String awsSecretKey = WebConfigurationManager.AppSettings["awsSecretKey"];//read from web.config
			if(String.IsNullOrEmpty(awsSecretKey)){
				throw new CBAIOPNClientException(
					"AccessKeyList is missing in the properties file...");
			}
			// Extract signature from the request
			String signature = request["Signature"];

			// Extract UUID from the request
			String uuid = request["UUID"];


			// Extract timestamp from the request
			String timestamp = request["Timestamp"];

			if(String.IsNullOrEmpty(signature) || String.IsNullOrEmpty(uuid) || String.IsNullOrEmpty(timestamp)
				|| String.IsNullOrEmpty(awsAccessKeyId)){
				throw new CBAIOPNClientException(
					"UUID/Timestamp/Signature/AWSAccessKeyId is missing in the Notification.");
			}
			String notificationType = request["NotificationType"];

			String notificationData = request ["NotificationData"];

			//TODO: perform all the required field validations

			//Validate timestamp
			ValidateTimeStamp(timestamp);

			// Calculate the signature using UUID, timestamp and the awsSecretKey
			String calcSig = SignatureCalculator.computeSignature(uuid, timestamp,
				awsSecretKey);

			if(calcSig!=signature){
				throw new CBAIOPNClientException(("Signature is incorrect. Recieved: " + signature + " ; Calculated: " + calcSig));
			}
		}

		protected void Process(HttpRequest request){
			log.Information ("Inside process...");
			String requestNotificationType = request["NotificationType"];

			String requestNotificationData = request ["NotificationData"];
			NotificationType notificationType;
			try
			{
				notificationType = (NotificationType)Enum.Parse (typeof(NotificationType), requestNotificationType);
			}
			catch (ArgumentException exception)
			{
				throw new CBAIOPNClientException("Unknown notification type : "
					+ requestNotificationType, exception);
			}



			INotificationProcessor processor = NotificationProcessorFactory.GetProcessor (notificationType);
			// Process the NotificationData
			HttpUtility.UrlDecode(requestNotificationData,Encoding.UTF8);
			processor.Process (requestNotificationData);
		}

		protected void ClearResponse(HttpContext context)
		{
			context.Response.ClearHeaders();
			context.Response.ClearContent();
			context.Response.Clear();
		}

		protected void SetResponse(HttpContext context, int statusCode, string message)
		{
			context.Response.StatusCode = statusCode;
			context.Response.Write (message);
		}

		protected void SetNoCacheHeaders(HttpContext context)
		{
			context.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
			context.Response.Cache.SetValidUntilExpires(false);
			context.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
			context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
			context.Response.Cache.SetNoStore();
		}

		protected void ValidateTimeStamp(string timestamp){
			if (String.IsNullOrEmpty(timestamp))
			{
				throw new CBAIOPNClientException(
					"Timestamp is absent in the notification.");
			}
			DateTime dateFromTimeStamp;
			try {
				dateFromTimeStamp = DateTime.Parse(timestamp);
			} catch (ParseException exception) {
				throw new CBAIOPNClientException(
					"Not able to parse the time stamp present in the notification.");
			}
			//TODO:consider your timezone and do the validation
			TimeSpan elapsedTime = DateTime.Now.Subtract (dateFromTimeStamp);
			if ( elapsedTime.TotalMinutes>15) {
				throw new CBAIOPNClientException("Timestamp is older than 15 minutes");
			}
		}

		public bool IsReusable {
			get {
				return false;
			}
		}
	}
}
	
