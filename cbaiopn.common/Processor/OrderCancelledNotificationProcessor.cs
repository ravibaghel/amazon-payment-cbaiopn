using System;
using cbaiopn.core;
using cbaiopn.core.model.iopn;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace cbaiopn.infrastructure.processor
{
	public class OrderCancelledNotificationProcessor:INotificationProcessor
	{
		#region INotificationProcessor implementation
		public void Process (string message)
		{
			var serializer = new XmlSerializer(typeof(OrderCancelledNotification));
			using (var mStrm = new MemoryStream (Encoding.UTF8.GetBytes (message))) {
				var data = (OrderCancelledNotification)serializer.Deserialize (mStrm);
				/*
             * Log the required fields. To be extended by merchant. Merchant can
             * stub in all the business logic to process the notification here.
             */
			}
		}
		#endregion
		
	}
}

