using System;
using System.Xml;
using System.Xml.Serialization;
using cbaiopn.core.model.iopn;
using System.IO;
using System.Text;

namespace cbaiopn.core
{
	public class Test
	{
		private string testData = @"UUID=5d1769d2-b217-4981-a499-fbad1b9acf15&Timestamp=2009-01-20T06%3A41%3A20.471Z&AWSAccessKe yId=AKIAJC2EVPPNIFRXIVKQ&Signature=Ltu1alXSqkyZRqzVSjI%2BDPuWQms%3D&NotificationType=NewOrde rNotification&NotificationData=%3C%3Fxml%20version%3D%221.0%22%20encoding%3D%22UTF-8%22%3F%3 E%0A%3CNewOrderNotification%20xmlns%3D%22http%3A%2F%2Fpayments.amazon.com%2Fcheckout%2F2009- 05-15%2F%22%3E%0A%20%20%3CNotificationReferenceId%3Eae51d3a6-7843-4cbb-ad1d-ee8cc591e10d%3C% 2FNotificationReferenceId%3E%0A%20%20%3CProcessedOrder%3E%0A%20%20%20%20%3COrderChannel%3EAm azon%20Checkout%20%28Live%29%3C%2FOrderChannel%3E%0A%20%20%20%20%3CAmazonOrderID%3E101-12345 67-9876543%3C%2FAmazonOrderID%3E%0A%20%20%20%20%3COrderDate%3E2009-08-31%3C%2FOrderDate%3E%0 A%20%20%20%20%3CBuyerInfo%3E%0A%20%20%20%20%20%20%3CBuyerName%3EKelly%20Green%3C%2FBuyerName %3E%0A%20%20%20%20%20%20%3CBuyerEmailAddress%3Esomeone%40amazon.com%3C%2FBuyerEmailAddress%3 E%0A%20%20%20%20%3C%2FBuyerInfo%3E%0A%20%20%20%20%3CShippingAddress%3E%0A%20%20%20%20%20%20% 3CName%3EKelly%20Green%3C%2FName%3E%0A%20%20%20%20%20%20%3CAddressFieldOne%3E123%20Oak%20Ave nue%20SE%20%3C%2FAddressFieldOne%3E%0A%20%20%20%20%20%20%3CAddressFieldTwo%3EApt.%20221-B%20 %3C%2FAddressFieldTwo%3E%0A%20%20%20%20%20%20%3CCity%3ESeattle%3C%2FCity%3E%0A%20%20%20%20%2 0%20%3CState%3EWA%3C%2FState%3E%0A%20%20%20%20%20%20%3CPostalCode%3E98104-1234%3C%2FPostalCo de%3E%0A%20%20%20%20%20%20%3CCountryCode%3EUSA%3C%2FCountryCode%3E%0A%20%20%20%20%3C%2FShipp ingAddress%3E%0A%20%20%20%20%3CShippingServiceLevel%3EStandard%3C%2FShippingServiceLevel%3E% 0A%20%20%20%20%3CProcessedOrderItems%3E%0A%20%20%20%20%20%20%3CProcessedOrderItem%3E%0A%20%2 0%20%20%20%20%20%20%3CAmazonOrderItemCode%3E12345%3C%2FAmazonOrderItemCode%3E%0A%20%20%20%20 %20%20%20%20%3CMerchantId%3EAEIOU1234AEIOU%3C%2FMerchantId%3E%0A%20%20%20%20%20%20%20%20%3CS KU%3EABC123%3C%2FSKU%3E%0A%20%20%20%20%20%20%20%20%3CTitle%3ERed%20Fish%3C%2FTitle%3E%0A%20% 20%20%20%20%20%20%20%3CDescription%3EA%20red%20fish%20packed%20in%20spring%20water.%3C%2FDes cription%3E%0A%20%20%20%20%20%20%20%20%3CClientRequestId%3E12345%3C%2FClientRequestId%3E%0A% 20%20%20%20%20%20%20%20%3CCartId%3Emiq%3A%2F%2Frose%3A1.0%2Fcart%2Fcba%3A1.0%2Fcart%3A2.0%2F AZ4B0ZS3LGLX%2FA3DBMG2ZGA2JEQ%2F1-1232431180394-57EEF607E6D40DB5%3C%2FCartId%3E%0A%20%20%20% 20%20%20%20%20%3CIntegratorId%3EVWXYZ98765VWXYZ%3C%2FIntegratorId%3E%0A%20%20%20%20%20%20%20 %20%3CIntegratorName%3Ewww.IntegratorWorld.com%3C%2FIntegratorName%3E%0A%20%20%20%20%20%20%2 0%20%3CPrice%3E%0A%20%20%20%20%20%20%20%20%20%20%3CAmount%3E5.0%3C%2FAmount%3E%0A%20%20%20%2 0%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%3C% 2FPrice%3E%0A%20%20%20%20%20%20%20%20%3CQuantity%3E1%3C%2FQuantity%3E%0A%20%20%20%20%20%20%2 0%20%3CWeight%3E%0A%20%20%20%20%20%20%20%20%20%20%3CAmount%3E1.0%3C%2FAmount%3E%0A%20%20%20% 20%20%20%20%20%20%20%3CUnit%3Elb%3C%2FUnit%3E%0A%20%20%20%20%20%20%20%20%3C%2FWeight%3E%0A%2 0%20%20%20%20%20%20%20%3CFulfillmentNetwork%3EMERCHANT%3C%2FFulfillmentNetwork%3E%0A%20%20%2 0%20%20%20%20%20%3CItemCharges%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%2 0%20%20%20%20%20%20%20%20%20%3CType%3EPrincipal%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%2 0%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E5.0%3C%2FAmount% 3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A %20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FCo mponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20% 20%20%3CType%3EShipping%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%2 0%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20% 20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20 %20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3ETax%3C%2F Type%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20% 20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCur rencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0 A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CCompone nt%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CType%3EShippingTax%3C%2FType%3E%0A%20%20%20%2 0%20%20%20%20%20%20%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount% 3E0.0%3C%2FAmount%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2F CurrencyCode%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%2 0%20%20%20%3C%2FComponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20% 20%20%20%20%20%20%20%20%3CType%3EPrincipalPromo%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%2 0%20%20%3CCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount% 3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A %20%20%20%20%20%20%20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FCo mponent%3E%0A%20%20%20%20%20%20%20%20%20%20%3CComponent%3E%0A%20%20%20%20%20%20%20%20%20%20% 20%20%3CType%3EShippingPromo%3C%2FType%3E%0A%20%20%20%20%20%20%20%20%20%20%20%20%3CCharge%3E %0A%20%20%20%20%20%20%20%20%20%20%20%20%20%20%3CAmount%3E0.0%3C%2FAmount%3E%0A%20%20%20%20%2 0%20%20%20%20%20%20%20%20%20%3CCurrencyCode%3EUSD%3C%2FCurrencyCode%3E%0A%20%20%20%20%20%20% 20%20%20%20%20%20%3C%2FCharge%3E%0A%20%20%20%20%20%20%20%20%20%20%3C%2FComponent%3E%0A%20%20 %20%20%20%20%20%20%3C%2FItemCharges%3E%0A%20%20%20%20%20%20%3C%2FProcessedOrderItem%3E%0A%20 %20%20%20%3C%2FProcessedOrderItems%3E%0A%20%20%3C%2FProcessedOrder%3E%0A%3C%2FNewOrderNotifi cation%3E";
		private string testxml=@"<?xml version=""1.0"" encoding=""UTF-8""?>
<NewOrderNotification xmlns=""http://payments.amazon.com/checkout/2008-11-30/"">
   <NotificationReferenceId>ae51d3a6-7843-4cbb-ad1d-ee8cc591e10d</NotificationReferenceId>
   <ProcessedOrder>
      <OrderChannel>Amazon Checkout (Live)</OrderChannel>
      <AmazonOrderID>101-1234567-9876543</AmazonOrderID>
      <OrderDate>2009-08-31</OrderDate>
      <BuyerInfo>
         <BuyerName>Kelly Green</BuyerName>
         <BuyerEmailAddress>someone@amazon.com</BuyerEmailAddress>
      </BuyerInfo>
      <ShippingAddress>
         <Name>Kelly Green</Name>
         <AddressFieldOne>123 Oak Avenue SE</AddressFieldOne>
         <AddressFieldTwo>Apt. 221-B</AddressFieldTwo>
         <City>Seattle</City>
         <State>WA</State>
         <PostalCode>98104-1234</PostalCode>
         <CountryCode>USA</CountryCode>
      </ShippingAddress>
      <ShippingServiceLevel>Standard</ShippingServiceLevel>
      <ProcessedOrderItems>
         <ProcessedOrderItem>
            <AmazonOrderItemCode>12345</AmazonOrderItemCode>
            <MerchantId>AEIOU1234AEIOU</MerchantId>
            <SKU>ABC123</SKU>
            <Title>Red Fish</Title>
            <Description>A red fish packed in spring water.</Description>
            <ClientRequestId>12345</ClientRequestId>
            <CartId>miq://rose:1.0/cart/cba:1.0/cart:2.0/ AEIOU1234AEIOU/AEIOU1234AEIOU/1-1232431180394-57EEF607E6D40DB5</CartId>
            <IntegratorId>VWXYZ98765VWXYZ</IntegratorId>
            <IntegratorName>www.IntegratorWorld.com</IntegratorName>
            <Price>
               <Amount>5.0</Amount>
               <CurrencyCode>USD</CurrencyCode>
            </Price>
            <Quantity>1</Quantity>
            <Weight>
               <Amount>1.0</Amount>
               <Unit>lb</Unit>
            </Weight>
            <FulfillmentNetwork>MERCHANT</FulfillmentNetwork>
            <ItemCharges>
               <Component>
                  <Type>Principal</Type>
                  <Charge>
                     <Amount>5.0</Amount>
                     <CurrencyCode>USD</CurrencyCode>
                  </Charge>
               </Component>
               <Component>
                  <Type>Shipping</Type>
                  <Charge>
                     <Amount>0.0</Amount>
                     <CurrencyCode>USD</CurrencyCode>
                  </Charge>
               </Component>
               <Component>
                  <Type>Tax</Type>
                  <Charge>
                     <Amount>0.0</Amount>
                     <CurrencyCode>USD</CurrencyCode>
                  </Charge>
               </Component>
               <Component>
                  <Type>ShippingTax</Type>
                  <Charge>
                     <Amount>0.0</Amount>
                     <CurrencyCode>USD</CurrencyCode>
                  </Charge>
               </Component>
               <Component>
                  <Type>PrincipalPromo</Type>
                  <Charge>
                     <Amount>0.0</Amount>
                     <CurrencyCode>USD</CurrencyCode>
                  </Charge>
               </Component>
               <Component>
                  <Type>ShippingPromo</Type>
                  <Charge>
                     <Amount>0.0</Amount>
                     <CurrencyCode>USD</CurrencyCode>
                  </Charge>
               </Component>
            </ItemCharges>
         </ProcessedOrderItem>
      </ProcessedOrderItems>
   </ProcessedOrder>
</NewOrderNotification>";
		public Test ()
		{
			string rawData = System.Uri.UnescapeDataString (testData);
			// Create an instance of the XmlSerializer specifying type and namespace.
			XmlSerializer serializer = new
				XmlSerializer(typeof(NewOrderNotification));

			// A FileStream is needed to read the XML document.
			//FileStream fs = new FileStream(filename, FileMode.Open);
			NewOrderNotification n;
			MemoryStream mStrm= new MemoryStream( Encoding.UTF8.GetBytes( testxml ) );
			n = (NewOrderNotification)serializer.Deserialize (mStrm);

		}
	}
}

