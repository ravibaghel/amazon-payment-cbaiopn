using System;
using System.Web;
using System.Web.UI;
using cbaiopn.infrastructure.processor;
using cbaiopn.core.common;
using cbaiopn.core;

namespace cbaiopn.web
{
	
	public class ProcessNotification : System.Web.IHttpHandler
	{
	
		public void ProcessRequest (HttpContext context)
		{
			//Clear the response (just in case)
			ClearResponse(context);
			//check only post
			if (context.Request.HttpMethod.ToUpper () == "POST") {
				
				string[] header = context.Request.Headers.AllKeys;
				// Authenticate the request using UUID, Timestamp and Signature
				AuthenticateRequest(context.Request);

				Process(context.Request);
			} else {
				context.Response.Headers.Add("Allow", "POST");
				context.Response.StatusCode = 405;
			}


		}

		protected void AuthenticateRequest(HttpRequest request)
		{
			String awsAccessKeyId = request["AWSAccessKeyId"];
			String awsSecretKey = "secret";//read from properties file

			// Extract signature from the request
			String signature = request["Signature"];

			// Extract UUID from the request
			String uuid = request["UUID"];

			// Extract timestamp from the request
			String timestamp = request["Timestamp"];

			String notificationType = request["NotificationType"];

			String notificationData = request ["NotificationData"];

			//TODO: perform all the required field validations

			//Validate timestamp
			ValidateTimeStamp(timestamp);

			// Calculate the signature using UUID, timestamp and the awsSecretKey
			String calcSig = SignatureCalculator.computeSignature(uuid, timestamp,
				awsSecretKey);

			if(calcSig!=signature){
				throw new Exception("Authentication failed");
			}
		}

		protected void Process(HttpRequest request){
			String requestNotificationType = request["NotificationType"];

			String requestNotificationData = request ["NotificationData"];
			NotificationType notificationType = (NotificationType)Enum.Parse (typeof(NotificationType), requestNotificationType);


			INotificationProcessor processor = NotificationProcessorFactory.GetProcessor (notificationType);
			processor.Process (requestNotificationData);
		}

		protected void ClearResponse(HttpContext context)
		{
			context.Response.ClearHeaders();
			context.Response.ClearContent();
			context.Response.Clear();
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
			
		}

		public bool IsReusable {
			get {
				return false;
			}
		}
	}
}
	
