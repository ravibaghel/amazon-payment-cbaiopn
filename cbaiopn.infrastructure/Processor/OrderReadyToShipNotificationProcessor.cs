using System;
using cbaiopn.core;
using System.Xml.Serialization;
using cbaiopn.core.model.iopn;
using System.IO;
using System.Text;
using Serilog;

namespace cbaiopn.infrastructure.processor
{
	public class OrderReadyToShipNotificationProcessor:INotificationProcessor
	{
		ILogger log = new LoggerConfiguration()
			.WriteTo.File("OrderReadyToShipNotificationProcessor.txt")
			.CreateLogger();
		#region INotificationProcessor implementation
		public void Process (string message)
		{
			var serializer = new XmlSerializer(typeof(OrderReadyToShipNotification));
			using (var mStrm = new MemoryStream (Encoding.UTF8.GetBytes (message))) {
				var data = (OrderReadyToShipNotification)serializer.Deserialize (mStrm);
				/*
             * Log the required fields. To be extended by merchant. Merchant can
             * stub in all the business logic to process the notification here.
             */
				log.Information("NotificationReferenceId:"+data.NotificationReferenceId);
			}
		}
		#endregion
		
	}
}

