using System;
using System.Xml;
using System.Xml.Serialization;
using cbaiopn.core.model.iopn;
using System.IO;
using System.Text;
using System.Collections.Specialized;
using System.Web;
using cbaiopn.core;
using cbaiopn.infrastructure.processor;

namespace cbaiopn.test
{
	public class Test
	{
		private string testData = @"UUID=5d1769d2-b217-4981-a499-fbad1b9acf15&Timestamp=2009-01-20T06%3A41%3A20.471Z&AWSAccessKeyId=AKIAJC2EVPPNIFRXIVKQ&Signature=Ltu1alXSqkyZRqzVSjI%2BDPuWQms%3D&NotificationType=NewOrderNotification&NotificationData=%3C%3Fxml%20version%3D%221.0%22%20encoding%3D%22UTF-8%22%3F%3E%0A%3CNewOrderNotification%20xmlns%3D%22http%3A%2F%2Fpayments.amazon.com%2Fcheckout%2F2008-11-30%2F%22%3E%0A%20%20%3CNotificationReferenceId%3Eae51d3a6-7843-4cbb-ad1d-ee8cc591e10d%3C%2FNotificationReferenceId%3E%0A%20%20%3CProcessedOrder%3E%0A%20%20%20%20%3COrderChannel%3EAmazon%20Checkout%20%28Live%29%3C%2FOrderChannel%3E%0A%20%20%20%20%3CAmazonOrderID%3E101-1234567-9876543%3C%2FAmazonOrderID%3E%0A%20%20%20%20%3COrderDate%3E2009-08-31%3C%2FOrderDate%3E%0A%20%20%20%20%3CBuyerInfo%3E%0A%20%20%20%20%20%20%3CBuyerName%3EKelly%20Green%3C%2FBuyerName%3E%0A%20%20%20%20%20%20%3CBuyerEmailAddress%3Esomeone%40amazon.com%3C%2FBuyerEmailAddress%3E%0A%20%20%20%20%3C%2FBuyerInfo%3E%0A%20%20%20%20%3CShippingAddress%3E%0A%20%20%20%20%20%20%3CName%3EKelly%20Green%3C%2FName%3E%0A%20%20%20%20%20%20%3CAddressFieldOne%3E123%20Oak%20Avenue%20SE%20%3C%2FAddressFieldOne%3E%0A%20%20%20%20%20%20%3CAddressFieldTwo%3EApt.%20221-B%20%3C%2FAddressFieldTwo%3E%0A%20%20%20%20%20%20%3CCity%3ESeattle%3C%2FCity%3E%0A%20%20%20%20%20%20%3CState%3EWA%3C%2FState%3E%0A%20%20%20%20%20%20%3CPostalCode%3E98104-1234%3C%2FPostalCode%3E%0A%20%20%20%20%20%20%3CCountryCode%3EUSA%3C%2FCountryCode%3E%0A%20%20%20%20%3C%2FShippingAddress%3E%0A%20%20%20%20%3CShippingServiceLevel%3EStandard%3C%2FShippingServiceLevel%3E%0A%20%20%20%20%3CProcessedOrderItems%3E%0A%20%20%20%20%20%20%3CProcessedOrderItem%3E%0A%20%20%20%20%20%20%20%20%3CAmazonOrderItemCode%3E12345%3C%2FAmazonOrderItemCode%3E%0A%20%20%20%20%20%20%20%20%3CMerchantId%3EAEIOU1234AEIOU%3C%2FMerchantId%3E%0A%20%20%20%20%20%20%20%20%3CSKU%3EABC123%3C%2FSKU%3E%0A%20%20%20%20%20%20%20%20%3CTitle%3ERed%20Fish%3C%2FTitle%3E%0A%20%20%20%20%20%20%20%20%3CDescription%3EA%20red%20fish%20packed%20in%20spring%20water.%3C%2FDescription%3E%0A%20%20%20%20%20%20%20%20%3CClientRequestId%3E12345%3C%2FClientRequestId%3E%0A%20%20%20%20%20%20%20%20%3CCartId%3Emiq%3A%2F%2Frose%3A1.0%2Fcart%2Fcba%3A1.0%2Fcart%3A2.0%2FAZ4B0ZS3LGLX%2FA3DBMG2ZGA2JEQ%2F1-1232431180394-57EEF607E6D40DB5%3C%2FCartId%3E%0A%20%20%20%20%20%20%20%20%3CIntegratorId%3EVWXYZ98765VWXYZ%3C%2FIntegratorId%3E%0A%20%20%20%20%20%20%20%20%3CIntegratorName%3Ewww.IntegratorWorld.com%3C%2FIntegratorName%3E%0A%20%20%20%20%20%20%20%20%3CPrice%3E%0A%20%20%20%20%20%20%20%20%20%20%3CAmount%3E5.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%3C%2FPrice%3E%0A%20%20%20%20%20%20%20%20%3CQuantity%3E1%3C%2FQuantity%3E%0A%20%20%20%20%20%20%20%20%3CWeight%3E%0A%20%20%20%20%20%20%20%20%20%20%3CAmount%3E1.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%3CUnit%3Elb%3C%2FUnit%3E%0A%20%20%20%20%20%20%20%20%3C%2FWeight%3E%0A%20%20%20%20%20%20%20%20%3CFulfillmentNetwork%3EMERCHANT%3C%2FFulfillmentNetwork%3E%0A%20%20%20%20%20%20%20%20%3CItemCharges%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3EPrincipal%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E5.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3EShipping%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3ETax%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3EShippingTax%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3EPrincipalPromo%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3EShippingPromo%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%3C%2FItemCharges%3E%0A%20%20%20%20%20%20%3C%2FProcessedOrderItem%3E%0A%20%20%20%20%3C%2FProcessedOrderItems%3E%0A%20%20%3C%2FProcessedOrder%3E%0A%3C%2FNewOrderNotification%3E";

		public Test ()
		{
			NameValueCollection qscoll = HttpUtility.ParseQueryString (testData);

			// Iterate through the collection.

			//foreach (String s in qscoll.AllKeys) {
			//	Console.WriteLine (s + ":" + qscoll [s]);
			//}
			// Create an instance of the XmlSerializer specifying type and namespace.

			var serializer = new
				XmlSerializer (typeof(NewOrderNotification));
			NotificationType notificationType = (NotificationType)Enum.Parse (typeof(NotificationType), qscoll ["NotificationType"]);
			// A FileStream is needed to read the XML document.
			//FileStream fs = new FileStream(filename, FileMode.Open);

			INotificationProcessor processor = NotificationProcessorFactory.GetProcessor (notificationType);
			processor.Process (qscoll ["NotificationData"]);
		}
	}
}

