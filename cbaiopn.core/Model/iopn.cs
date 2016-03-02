/*------------------------------------------------------------------------------
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
------------------------------------------------------------------------------*/

namespace cbaiopn.core.model.iopn
{
   
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=false)]
   public enum ShippingServiceLevel
   {
      /// <remarks/>
      Standard,
      /// <remarks/>
      Expedited,
      /// <remarks/>
      OneDay,
      /// <remarks/>
      TwoDay,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class Price
   {
      private double amountField;
      private string currencyCodeField;
      /// <remarks/>
      public double Amount
      {
         get
         {
            return this.amountField;
         }
         set
         {
            this.amountField = value;
         }
      }
      /// <remarks/>
      public string CurrencyCode
      {
         get
         {
            return this.currencyCodeField;
         }
         set
         {
            this.currencyCodeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class ProcessedOrderItem
   {
      private string amazonOrderItemCodeField;
      private string merchantIdField;
      private string sKUField;
      private string titleField;
      private string descriptionField;
      private string clientRequestIdField;
      private string cartIdField;
      private string integratorIdField;
      private string integratorNameField;
      private Price priceField;
      private string quantityField;
      private Weight weightField;
      private string categoryField;
      private string conditionField;
      private FulfillmentNetwork fulfillmentNetworkField;
      private bool fulfillmentNetworkFieldSpecified;
      private ChargesComponent[] itemChargesField;
      private MerchantCustomDataXML cartCustomDataField;
      private MerchantCustomDataXML itemCustomDataField;
      private MerchantCustomDataXML shippingCustomDataField;
      private ItemAttributes itemAttributesField;
      /// <remarks/>
      public string AmazonOrderItemCode
      {
         get
         {
            return this.amazonOrderItemCodeField;
         }
         set
         {
            this.amazonOrderItemCodeField = value;
         }
      }
      /// <remarks/>
      public string MerchantId
      {
         get
         {
            return this.merchantIdField;
         }
         set
         {
            this.merchantIdField = value;
         }
      }
      /// <remarks/>
      public string SKU
      {
         get
         {
            return this.sKUField;
         }
         set
         {
            this.sKUField = value;
         }
      }
      /// <remarks/>
      public string Title
      {
         get
         {
            return this.titleField;
         }
         set
         {
            this.titleField = value;
         }
      }
      /// <remarks/>
      public string Description
      {
         get
         {
            return this.descriptionField;
         }
         set
         {
            this.descriptionField = value;
         }
      }
      /// <remarks/>
      public string ClientRequestId
      {
         get
         {
            return this.clientRequestIdField;
         }
         set
         {
            this.clientRequestIdField = value;
         }
      }
      /// <remarks/>
      public string CartId
      {
         get
         {
            return this.cartIdField;
         }
         set
         {
            this.cartIdField = value;
         }
      }
      /// <remarks/>
      public string IntegratorId
      {
         get
         {
            return this.integratorIdField;
         }
         set
         {
            this.integratorIdField = value;
         }
      }
      /// <remarks/>
      public string IntegratorName
      {
         get
         {
            return this.integratorNameField;
         }
         set
         {
            this.integratorNameField = value;
         }
      }
      /// <remarks/>
      public Price Price
      {
         get
         {
            return this.priceField;
         }
         set
         {
            this.priceField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger")]
      public string Quantity
      {
         get
         {
            return this.quantityField;
         }
         set
         {
            this.quantityField = value;
         }
      }
      /// <remarks/>
      public Weight Weight
      {
         get
         {
            return this.weightField;
         }
         set
         {
            this.weightField = value;
         }
      }
      /// <remarks/>
      public string Category
      {
         get
         {
            return this.categoryField;
         }
         set
         {
            this.categoryField = value;
         }
      }
      /// <remarks/>
      public string Condition
      {
         get
         {
            return this.conditionField;
         }
         set
         {
            this.conditionField = value;
         }
      }
      /// <remarks/>
      public FulfillmentNetwork FulfillmentNetwork
      {
         get
         {
            return this.fulfillmentNetworkField;
         }
         set
         {
            this.fulfillmentNetworkField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool FulfillmentNetworkSpecified
      {
         get
         {
            return this.fulfillmentNetworkFieldSpecified;
         }
         set
         {
            this.fulfillmentNetworkFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("Component", IsNullable=false)]
      public ChargesComponent[] ItemCharges
      {
         get
         {
            return this.itemChargesField;
         }
         set
         {
            this.itemChargesField = value;
         }
      }
      /// <remarks/>
      public MerchantCustomDataXML CartCustomData
      {
         get
         {
            return this.cartCustomDataField;
         }
         set
         {
            this.cartCustomDataField = value;
         }
      }
      /// <remarks/>
      public MerchantCustomDataXML ItemCustomData
      {
         get
         {
            return this.itemCustomDataField;
         }
         set
         {
            this.itemCustomDataField = value;
         }
      }
      /// <remarks/>
      public MerchantCustomDataXML ShippingCustomData
      {
         get
         {
            return this.shippingCustomDataField;
         }
         set
         {
            this.shippingCustomDataField = value;
         }
      }
      /// <remarks/>
      public ItemAttributes ItemAttributes
      {
         get
         {
            return this.itemAttributesField;
         }
         set
         {
            this.itemAttributesField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class Weight
   {
      private double amountField;
      private string unitField;
      /// <remarks/>
      public double Amount
      {
         get
         {
            return this.amountField;
         }
         set
         {
            this.amountField = value;
         }
      }
      /// <remarks/>
      public string Unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=false)]
   public enum FulfillmentNetwork
   {
      /// <remarks/>
      MERCHANT,
      /// <remarks/>
      AMAZON_NA,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   public  class ChargesComponent
   {
      private ComponentType typeField;
      private Price chargeField;
      /// <remarks/>
      public ComponentType Type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      public Price Charge
      {
         get
         {
            return this.chargeField;
         }
         set
         {
            this.chargeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=false)]
   public enum ComponentType
   {
      /// <remarks/>
      Principal,
      /// <remarks/>
      Shipping,
      /// <remarks/>
      GiftWrap,
      /// <remarks/>
      Other,
      /// <remarks/>
      Tax,
      /// <remarks/>
      ShippingTax,
      /// <remarks/>
      GiftWrapTax,
      /// <remarks/>
      OtherTax,
      /// <remarks/>
      PrincipalPromo,
      /// <remarks/>
      ShippingPromo,
      /// <remarks/>
      GiftWrapPromo,
      /// <remarks/>
      OtherPromo,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class MerchantCustomDataXML
   {
      private System.Xml.XmlNode[] anyField;
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlNode[] Any
      {
         get
         {
            return this.anyField;
         }
         set
         {
            this.anyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class ItemAttributes
   {
      private System.Xml.XmlElement[] anyField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlElement[] Any
      {
         get
         {
            return this.anyField;
         }
         set
         {
            this.anyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class ShippingAddress
   {
      private string nameField;
      private string addressFieldOneField;
      private string addressFieldTwoField;
      private string addressFieldThreeField;
      private string cityField;
      private string stateField;
      private string postalCodeField;
      private string countryCodeField;
      private string phoneNumberField;
      /// <remarks/>
      public string Name
      {
         get
         {
            return this.nameField;
         }
         set
         {
            this.nameField = value;
         }
      }
      /// <remarks/>
      public string AddressFieldOne
      {
         get
         {
            return this.addressFieldOneField;
         }
         set
         {
            this.addressFieldOneField = value;
         }
      }
      /// <remarks/>
      public string AddressFieldTwo
      {
         get
         {
            return this.addressFieldTwoField;
         }
         set
         {
            this.addressFieldTwoField = value;
         }
      }
      /// <remarks/>
      public string AddressFieldThree
      {
         get
         {
            return this.addressFieldThreeField;
         }
         set
         {
            this.addressFieldThreeField = value;
         }
      }
      /// <remarks/>
      public string City
      {
         get
         {
            return this.cityField;
         }
         set
         {
            this.cityField = value;
         }
      }
      /// <remarks/>
      public string State
      {
         get
         {
            return this.stateField;
         }
         set
         {
            this.stateField = value;
         }
      }
      /// <remarks/>
      public string PostalCode
      {
         get
         {
            return this.postalCodeField;
         }
         set
         {
            this.postalCodeField = value;
         }
      }
      /// <remarks/>
      public string CountryCode
      {
         get
         {
            return this.countryCodeField;
         }
         set
         {
            this.countryCodeField = value;
         }
      }
      /// <remarks/>
      public string PhoneNumber
      {
         get
         {
            return this.phoneNumberField;
         }
         set
         {
            this.phoneNumberField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class BillingAddress
   {
      private string nameField;
      private string addressFieldOneField;
      private string addressFieldTwoField;
      private string addressFieldThreeField;
      private string cityField;
      private string stateField;
      private string postalCodeField;
      private string countryCodeField;
      /// <remarks/>
      public string Name
      {
         get
         {
            return this.nameField;
         }
         set
         {
            this.nameField = value;
         }
      }
      /// <remarks/>
      public string AddressFieldOne
      {
         get
         {
            return this.addressFieldOneField;
         }
         set
         {
            this.addressFieldOneField = value;
         }
      }
      /// <remarks/>
      public string AddressFieldTwo
      {
         get
         {
            return this.addressFieldTwoField;
         }
         set
         {
            this.addressFieldTwoField = value;
         }
      }
      /// <remarks/>
      public string AddressFieldThree
      {
         get
         {
            return this.addressFieldThreeField;
         }
         set
         {
            this.addressFieldThreeField = value;
         }
      }
      /// <remarks/>
      public string City
      {
         get
         {
            return this.cityField;
         }
         set
         {
            this.cityField = value;
         }
      }
      /// <remarks/>
      public string State
      {
         get
         {
            return this.stateField;
         }
         set
         {
            this.stateField = value;
         }
      }
      /// <remarks/>
      public string PostalCode
      {
         get
         {
            return this.postalCodeField;
         }
         set
         {
            this.postalCodeField = value;
         }
      }
      /// <remarks/>
      public string CountryCode
      {
         get
         {
            return this.countryCodeField;
         }
         set
         {
            this.countryCodeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class NewOrderNotification
   {
      private string notificationReferenceIdField;
      private ProcessedOrder processedOrderField;
      private System.Xml.XmlElement[] anyField;
      /// <remarks/>
      public string NotificationReferenceId
      {
         get
         {
            return this.notificationReferenceIdField;
         }
         set
         {
            this.notificationReferenceIdField = value;
         }
      }
      /// <remarks/>
      public ProcessedOrder ProcessedOrder
      {
         get
         {
            return this.processedOrderField;
         }
         set
         {
            this.processedOrderField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlElement[] Any
      {
         get
         {
            return this.anyField;
         }
         set
         {
            this.anyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class ProcessedOrder
   {
      private string orderChannelField;
      private string amazonOrderIDField;
      private System.DateTime orderDateField;
      private ProcessedOrderBuyerInfo buyerInfoField;
      private BillingAddress billingAddressField;
      private ShippingAddress shippingAddressField;
      private ShippingServiceLevel shippingServiceLevelField;
      private bool shippingServiceLevelFieldSpecified;
      private ProcessedOrderItem[] processedOrderItemsField;
      private string displayableShippingLabelField;
      private System.Xml.XmlElement[] anyField;
      /// <remarks/>
      public string OrderChannel
      {
         get
         {
            return this.orderChannelField;
         }
         set
         {
            this.orderChannelField = value;
         }
      }
      /// <remarks/>
      public string AmazonOrderID
      {
         get
         {
            return this.amazonOrderIDField;
         }
         set
         {
            this.amazonOrderIDField = value;
         }
      }
      /// <remarks/>
      public System.DateTime OrderDate
      {
         get
         {
            return this.orderDateField;
         }
         set
         {
            this.orderDateField = value;
         }
      }
      /// <remarks/>
      public ProcessedOrderBuyerInfo BuyerInfo
      {
         get
         {
            return this.buyerInfoField;
         }
         set
         {
            this.buyerInfoField = value;
         }
      }
      /// <remarks/>
      public BillingAddress BillingAddress
      {
         get
         {
            return this.billingAddressField;
         }
         set
         {
            this.billingAddressField = value;
         }
      }
      /// <remarks/>
      public ShippingAddress ShippingAddress
      {
         get
         {
            return this.shippingAddressField;
         }
         set
         {
            this.shippingAddressField = value;
         }
      }
      /// <remarks/>
      public ShippingServiceLevel ShippingServiceLevel
      {
         get
         {
            return this.shippingServiceLevelField;
         }
         set
         {
            this.shippingServiceLevelField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool ShippingServiceLevelSpecified
      {
         get
         {
            return this.shippingServiceLevelFieldSpecified;
         }
         set
         {
            this.shippingServiceLevelFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public ProcessedOrderItem[] ProcessedOrderItems
      {
         get
         {
            return this.processedOrderItemsField;
         }
         set
         {
            this.processedOrderItemsField = value;
         }
      }
      /// <remarks/>
      public string DisplayableShippingLabel
      {
         get
         {
            return this.displayableShippingLabelField;
         }
         set
         {
            this.displayableShippingLabelField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlElement[] Any
      {
         get
         {
            return this.anyField;
         }
         set
         {
            this.anyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   public  class ProcessedOrderBuyerInfo
   {
      private string buyerNameField;
      private string buyerEmailAddressField;
      private System.Xml.XmlElement[] anyField;
      /// <remarks/>
      public string BuyerName
      {
         get
         {
            return this.buyerNameField;
         }
         set
         {
            this.buyerNameField = value;
         }
      }
      /// <remarks/>
      public string BuyerEmailAddress
      {
         get
         {
            return this.buyerEmailAddressField;
         }
         set
         {
            this.buyerEmailAddressField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlElement[] Any
      {
         get
         {
            return this.anyField;
         }
         set
         {
            this.anyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class OrderReadyToShipNotification
   {
      private string notificationReferenceIdField;
      private ProcessedOrder processedOrderField;
      private System.Xml.XmlElement[] anyField;
      /// <remarks/>
      public string NotificationReferenceId
      {
         get
         {
            return this.notificationReferenceIdField;
         }
         set
         {
            this.notificationReferenceIdField = value;
         }
      }
      /// <remarks/>
      public ProcessedOrder ProcessedOrder
      {
         get
         {
            return this.processedOrderField;
         }
         set
         {
            this.processedOrderField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlElement[] Any
      {
         get
         {
            return this.anyField;
         }
         set
         {
            this.anyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class OrderCancelledNotification
   {
      private string notificationReferenceIdField;
      private ProcessedOrder processedOrderField;
      private System.Xml.XmlElement[] anyField;
      /// <remarks/>
      public string NotificationReferenceId
      {
         get
         {
            return this.notificationReferenceIdField;
         }
         set
         {
            this.notificationReferenceIdField = value;
         }
      }
      /// <remarks/>
      public ProcessedOrder ProcessedOrder
      {
         get
         {
            return this.processedOrderField;
         }
         set
         {
            this.processedOrderField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlElement[] Any
      {
         get
         {
            return this.anyField;
         }
         set
         {
            this.anyField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class ProcessedOrderItems
   {
      private ProcessedOrderItem[] processedOrderItemField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ProcessedOrderItem")]
      public ProcessedOrderItem[] ProcessedOrderItem
      {
         get
         {
            return this.processedOrderItemField;
         }
         set
         {
            this.processedOrderItemField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2008-11-30/", IsNullable=true)]
   public  class Charges
   {
      private ChargesComponent[] componentField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Component")]
      public ChargesComponent[] Component
      {
         get
         {
            return this.componentField;
         }
         set
         {
            this.componentField = value;
         }
      }
   }
}
