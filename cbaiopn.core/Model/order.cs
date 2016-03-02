/*------------------------------------------------------------------------------
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
------------------------------------------------------------------------------*/

namespace cbaiopn.core.model.order
{
   
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Order
   {
      private string clientRequestIdField;
      private string expirationDateField;
      private Cart cartField;
      private TaxTable defaultTaxTableField;
      private TaxTable[] taxTablesField;
      private Promotion[] promotionsField;
      private ShippingMethod[] shippingMethodsField;
      private string integratorIdField;
      private string integratorNameField;
      private string returnUrlField;
      private string cancelUrlField;
      private string yourAccountUrlField;
      private MerchantUpsellItem[] merchantUpsellItemsField;
      private AmazonUpsellPreferences amazonUpsellPreferencesField;
      private OrderCalculationCallbacks orderCalculationCallbacksField;
      private ShippingAddress[] shippingAddressesField;
      private bool disablePromotionCodeField;
      private bool disablePromotionCodeFieldSpecified;
      private ParameterizedUrl[] parameterizedUrlsField;
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
      public string ExpirationDate
      {
         get
         {
            return this.expirationDateField;
         }
         set
         {
            this.expirationDateField = value;
         }
      }
      /// <remarks/>
      public Cart Cart
      {
         get
         {
            return this.cartField;
         }
         set
         {
            this.cartField = value;
         }
      }
      /// <remarks/>
      public TaxTable DefaultTaxTable
      {
         get
         {
            return this.defaultTaxTableField;
         }
         set
         {
            this.defaultTaxTableField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public TaxTable[] TaxTables
      {
         get
         {
            return this.taxTablesField;
         }
         set
         {
            this.taxTablesField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public Promotion[] Promotions
      {
         get
         {
            return this.promotionsField;
         }
         set
         {
            this.promotionsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public ShippingMethod[] ShippingMethods
      {
         get
         {
            return this.shippingMethodsField;
         }
         set
         {
            this.shippingMethodsField = value;
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
      [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
      public string ReturnUrl
      {
         get
         {
            return this.returnUrlField;
         }
         set
         {
            this.returnUrlField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
      public string CancelUrl
      {
         get
         {
            return this.cancelUrlField;
         }
         set
         {
            this.cancelUrlField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
      public string YourAccountUrl
      {
         get
         {
            return this.yourAccountUrlField;
         }
         set
         {
            this.yourAccountUrlField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public MerchantUpsellItem[] MerchantUpsellItems
      {
         get
         {
            return this.merchantUpsellItemsField;
         }
         set
         {
            this.merchantUpsellItemsField = value;
         }
      }
      /// <remarks/>
      public AmazonUpsellPreferences AmazonUpsellPreferences
      {
         get
         {
            return this.amazonUpsellPreferencesField;
         }
         set
         {
            this.amazonUpsellPreferencesField = value;
         }
      }
      /// <remarks/>
      public OrderCalculationCallbacks OrderCalculationCallbacks
      {
         get
         {
            return this.orderCalculationCallbacksField;
         }
         set
         {
            this.orderCalculationCallbacksField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public ShippingAddress[] ShippingAddresses
      {
         get
         {
            return this.shippingAddressesField;
         }
         set
         {
            this.shippingAddressesField = value;
         }
      }
      /// <remarks/>
      public bool DisablePromotionCode
      {
         get
         {
            return this.disablePromotionCodeField;
         }
         set
         {
            this.disablePromotionCodeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool DisablePromotionCodeSpecified
      {
         get
         {
            return this.disablePromotionCodeFieldSpecified;
         }
         set
         {
            this.disablePromotionCodeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public ParameterizedUrl[] ParameterizedUrls
      {
         get
         {
            return this.parameterizedUrlsField;
         }
         set
         {
            this.parameterizedUrlsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Cart
   {
      private Item[] itemsField;
      private string cartPromotionIdField;
      private CartTaxAmount[] cartTaxAmountsField;
      private MerchantCalculatedPaymentAmounts paymentAmountsField;
      private CustomDataXML cartCustomDataField;
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public Item[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      public string CartPromotionId
      {
         get
         {
            return this.cartPromotionIdField;
         }
         set
         {
            this.cartPromotionIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public CartTaxAmount[] CartTaxAmounts
      {
         get
         {
            return this.cartTaxAmountsField;
         }
         set
         {
            this.cartTaxAmountsField = value;
         }
      }
      /// <remarks/>
      public MerchantCalculatedPaymentAmounts PaymentAmounts
      {
         get
         {
            return this.paymentAmountsField;
         }
         set
         {
            this.paymentAmountsField = value;
         }
      }
      /// <remarks/>
      public CustomDataXML CartCustomData
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
   }
   /// <remarks/>
   [System.Xml.Serialization.XmlIncludeAttribute(typeof(MerchantUpsellItem))]
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Item
   {
      private string sKUField;
      private string merchantIdField;
      private string titleField;
      private string descriptionField;
      private Price priceField;
      private string quantityField;
      private Weight weightField;
      private string uRLField;
      private string categoryField;
      private string conditionField;
      private string taxTableIdField;
      private PromotionIds promotionIdsField;
      private string[] shippingMethodIdsField;
      private FulfillmentNetwork fulfillmentNetworkField;
      private bool fulfillmentNetworkFieldSpecified;
      private Images imagesField;
      private CatalogSource catalogSourceField;
      private bool catalogSourceFieldSpecified;
      private MerchantCalculatedItemAmounts paymentAmountsField;
      private CustomDataXML itemCustomDataField;
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
      [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger")]
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
      [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
      public string URL
      {
         get
         {
            return this.uRLField;
         }
         set
         {
            this.uRLField = value;
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
      public string TaxTableId
      {
         get
         {
            return this.taxTableIdField;
         }
         set
         {
            this.taxTableIdField = value;
         }
      }
      /// <remarks/>
      public PromotionIds PromotionIds
      {
         get
         {
            return this.promotionIdsField;
         }
         set
         {
            this.promotionIdsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("ShippingMethodId", IsNullable=false)]
      public string[] ShippingMethodIds
      {
         get
         {
            return this.shippingMethodIdsField;
         }
         set
         {
            this.shippingMethodIdsField = value;
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
      public Images Images
      {
         get
         {
            return this.imagesField;
         }
         set
         {
            this.imagesField = value;
         }
      }
      /// <remarks/>
      public CatalogSource CatalogSource
      {
         get
         {
            return this.catalogSourceField;
         }
         set
         {
            this.catalogSourceField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool CatalogSourceSpecified
      {
         get
         {
            return this.catalogSourceFieldSpecified;
         }
         set
         {
            this.catalogSourceFieldSpecified = value;
         }
      }
      /// <remarks/>
      public MerchantCalculatedItemAmounts PaymentAmounts
      {
         get
         {
            return this.paymentAmountsField;
         }
         set
         {
            this.paymentAmountsField = value;
         }
      }
      /// <remarks/>
      public CustomDataXML ItemCustomData
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
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Price
   {
      private string amountField;
      private string currencyCodeField;
      /// <remarks/>
      public string Amount
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
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class CartTaxAmount
   {
      private string shippingMethodIdField;
      private ShippingServiceLevel serviceLevelField;
      private bool serviceLevelFieldSpecified;
      private Price taxAmountField;
      /// <remarks/>
      public string ShippingMethodId
      {
         get
         {
            return this.shippingMethodIdField;
         }
         set
         {
            this.shippingMethodIdField = value;
         }
      }
      /// <remarks/>
      public ShippingServiceLevel ServiceLevel
      {
         get
         {
            return this.serviceLevelField;
         }
         set
         {
            this.serviceLevelField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool ServiceLevelSpecified
      {
         get
         {
            return this.serviceLevelFieldSpecified;
         }
         set
         {
            this.serviceLevelFieldSpecified = value;
         }
      }
      /// <remarks/>
      public Price TaxAmount
      {
         get
         {
            return this.taxAmountField;
         }
         set
         {
            this.taxAmountField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=false)]
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
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class TaxRule
   {
      private double rateField;
      private bool isShippingTaxedField;
      private bool isShippingTaxedFieldSpecified;
      private string uSZipRegionField;
      private string uSStateRegionField;
      private WorldRegion worldRegionField;
      private PredefinedRegion predefinedRegionField;
      private bool predefinedRegionFieldSpecified;
      /// <remarks/>
      public double Rate
      {
         get
         {
            return this.rateField;
         }
         set
         {
            this.rateField = value;
         }
      }
      /// <remarks/>
      public bool IsShippingTaxed
      {
         get
         {
            return this.isShippingTaxedField;
         }
         set
         {
            this.isShippingTaxedField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool IsShippingTaxedSpecified
      {
         get
         {
            return this.isShippingTaxedFieldSpecified;
         }
         set
         {
            this.isShippingTaxedFieldSpecified = value;
         }
      }
      /// <remarks/>
      public string USZipRegion
      {
         get
         {
            return this.uSZipRegionField;
         }
         set
         {
            this.uSZipRegionField = value;
         }
      }
      /// <remarks/>
      public string USStateRegion
      {
         get
         {
            return this.uSStateRegionField;
         }
         set
         {
            this.uSStateRegionField = value;
         }
      }
      /// <remarks/>
      public WorldRegion WorldRegion
      {
         get
         {
            return this.worldRegionField;
         }
         set
         {
            this.worldRegionField = value;
         }
      }
      /// <remarks/>
      public PredefinedRegion PredefinedRegion
      {
         get
         {
            return this.predefinedRegionField;
         }
         set
         {
            this.predefinedRegionField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool PredefinedRegionSpecified
      {
         get
         {
            return this.predefinedRegionFieldSpecified;
         }
         set
         {
            this.predefinedRegionFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class WorldRegion
   {
      private string postalRegionField;
      private string countryCodeField;
      /// <remarks/>
      public string PostalRegion
      {
         get
         {
            return this.postalRegionField;
         }
         set
         {
            this.postalRegionField = value;
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
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=false)]
   public enum PredefinedRegion
   {
      /// <remarks/>
      USContinental48States,
      /// <remarks/>
      USFull50States,
      /// <remarks/>
      USAll,
      /// <remarks/>
      WorldAll,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class TaxTable
   {
      private string taxTableIdField;
      private TaxRule[] taxRulesField;
      /// <remarks/>
      public string TaxTableId
      {
         get
         {
            return this.taxTableIdField;
         }
         set
         {
            this.taxTableIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
      public TaxRule[] TaxRules
      {
         get
         {
            return this.taxRulesField;
         }
         set
         {
            this.taxRulesField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Promotion
   {
      private string promotionIdField;
      private string descriptionField;
      private PromotionBenefit benefitField;
      /// <remarks/>
      public string PromotionId
      {
         get
         {
            return this.promotionIdField;
         }
         set
         {
            this.promotionIdField = value;
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
      public PromotionBenefit Benefit
      {
         get
         {
            return this.benefitField;
         }
         set
         {
            this.benefitField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class PromotionBenefit
   {
      private double discountRateField;
      private bool discountRateFieldSpecified;
      private Price fixedAmountDiscountField;
      /// <remarks/>
      public double DiscountRate
      {
         get
         {
            return this.discountRateField;
         }
         set
         {
            this.discountRateField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool DiscountRateSpecified
      {
         get
         {
            return this.discountRateFieldSpecified;
         }
         set
         {
            this.discountRateFieldSpecified = value;
         }
      }
      /// <remarks/>
      public Price FixedAmountDiscount
      {
         get
         {
            return this.fixedAmountDiscountField;
         }
         set
         {
            this.fixedAmountDiscountField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
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
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class ShippingMethod
   {
      private string shippingMethodIdField;
      private ShippingServiceLevel serviceLevelField;
      private ShippingRate rateField;
      private object[] includedRegionsField;
      private object[] excludedRegionsField;
      private string displayableShippingLabelField;
      /// <remarks/>
      public string ShippingMethodId
      {
         get
         {
            return this.shippingMethodIdField;
         }
         set
         {
            this.shippingMethodIdField = value;
         }
      }
      /// <remarks/>
      public ShippingServiceLevel ServiceLevel
      {
         get
         {
            return this.serviceLevelField;
         }
         set
         {
            this.serviceLevelField = value;
         }
      }
      /// <remarks/>
      public ShippingRate Rate
      {
         get
         {
            return this.rateField;
         }
         set
         {
            this.rateField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("RegionDefinition", IsNullable=false)]
      public object[] IncludedRegions
      {
         get
         {
            return this.includedRegionsField;
         }
         set
         {
            this.includedRegionsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("RegionDefinition", IsNullable=false)]
      public object[] ExcludedRegions
      {
         get
         {
            return this.excludedRegionsField;
         }
         set
         {
            this.excludedRegionsField = value;
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
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class ShippingRate
   {
      private Price weightBasedField;
      private Price itemQuantityBasedField;
      private Price shipmentBasedField;
      /// <remarks/>
      public Price WeightBased
      {
         get
         {
            return this.weightBasedField;
         }
         set
         {
            this.weightBasedField = value;
         }
      }
      /// <remarks/>
      public Price ItemQuantityBased
      {
         get
         {
            return this.itemQuantityBasedField;
         }
         set
         {
            this.itemQuantityBasedField = value;
         }
      }
      /// <remarks/>
      public Price ShipmentBased
      {
         get
         {
            return this.shipmentBasedField;
         }
         set
         {
            this.shipmentBasedField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class MerchantUpsellItem : Item
   {
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class ParameterizedUrl
   {
      private string urlField;
      private UrlParameter[] urlParameterField;
      /// <remarks/>
      public string Url
      {
         get
         {
            return this.urlField;
         }
         set
         {
            this.urlField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("UrlParameter")]
      public UrlParameter[] UrlParameter
      {
         get
         {
            return this.urlParameterField;
         }
         set
         {
            this.urlParameterField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class UrlParameter
   {
      private string nameField;
      private UrlParameterType typeField;
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
      public UrlParameterType Type
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
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=false)]
   public enum UrlParameterType
   {
      /// <remarks/>
      BuyerId,
      /// <remarks/>
      OrderId,
      /// <remarks/>
      OrderSubtotal,
      /// <remarks/>
      OrderSubtotalPlusShipping,
      /// <remarks/>
      OrderSubtotalPlusTax,
      /// <remarks/>
      OrderTotal,
      /// <remarks/>
      PromotionAmount,
      /// <remarks/>
      ShippingAmount,
      /// <remarks/>
      ShippingCity,
      /// <remarks/>
      ShippingCountryCode,
      /// <remarks/>
      ShippingPostalCode,
      /// <remarks/>
      ShippingState,
      /// <remarks/>
      TaxAmount,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
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
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class PromotionIds
   {
      private string promotionIdField;
      /// <remarks/>
      public string PromotionId
      {
         get
         {
            return this.promotionIdField;
         }
         set
         {
            this.promotionIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=false)]
   public enum FulfillmentNetwork
   {
      /// <remarks/>
      MERCHANT,
      /// <remarks/>
      AMAZON_NA,
      /// <remarks/>
      AMAZON,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Images
   {
      private Image imageField;
      /// <remarks/>
      public Image Image
      {
         get
         {
            return this.imageField;
         }
         set
         {
            this.imageField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Image
   {
      private string uRLField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
      public string URL
      {
         get
         {
            return this.uRLField;
         }
         set
         {
            this.uRLField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=false)]
   public enum CatalogSource
   {
      /// <remarks/>
      AMAZON,
      /// <remarks/>
      MERCHANT,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class MerchantCalculatedItemAmounts
   {
      private Price taxAmountField;
      private Promotion promotionField;
      private Price shippingAmountField;
      /// <remarks/>
      public Price TaxAmount
      {
         get
         {
            return this.taxAmountField;
         }
         set
         {
            this.taxAmountField = value;
         }
      }
      /// <remarks/>
      public Promotion Promotion
      {
         get
         {
            return this.promotionField;
         }
         set
         {
            this.promotionField = value;
         }
      }
      /// <remarks/>
      public Price ShippingAmount
      {
         get
         {
            return this.shippingAmountField;
         }
         set
         {
            this.shippingAmountField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class CustomDataXML
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
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class MerchantCalculatedPaymentAmounts
   {
      private Price taxAmountField;
      private Promotion promotionField;
      private MerchantCalculatedPaymentAmountsShipping shippingField;
      /// <remarks/>
      public Price TaxAmount
      {
         get
         {
            return this.taxAmountField;
         }
         set
         {
            this.taxAmountField = value;
         }
      }
      /// <remarks/>
      public Promotion Promotion
      {
         get
         {
            return this.promotionField;
         }
         set
         {
            this.promotionField = value;
         }
      }
      /// <remarks/>
      public MerchantCalculatedPaymentAmountsShipping Shipping
      {
         get
         {
            return this.shippingField;
         }
         set
         {
            this.shippingField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   public  class MerchantCalculatedPaymentAmountsShipping
   {
      private Price shippingAmountField;
      private ShippingServiceLevel shippingServiceLevelField;
      private string displayableShippingLabelField;
      /// <remarks/>
      public Price ShippingAmount
      {
         get
         {
            return this.shippingAmountField;
         }
         set
         {
            this.shippingAmountField = value;
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
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class AmazonUpsellPreferences
   {
      private string associateTagField;
      private string[] exclusionCategoriesField;
      private string[] inclusionCategoriesField;
      private string[] amazonUpsellItemsField;
      /// <remarks/>
      public string AssociateTag
      {
         get
         {
            return this.associateTagField;
         }
         set
         {
            this.associateTagField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("Category", IsNullable=false)]
      public string[] ExclusionCategories
      {
         get
         {
            return this.exclusionCategoriesField;
         }
         set
         {
            this.exclusionCategoriesField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("Category", IsNullable=false)]
      public string[] InclusionCategories
      {
         get
         {
            return this.inclusionCategoriesField;
         }
         set
         {
            this.inclusionCategoriesField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlArrayItemAttribute("ASIN", IsNullable=false)]
      public string[] AmazonUpsellItems
      {
         get
         {
            return this.amazonUpsellItemsField;
         }
         set
         {
            this.amazonUpsellItemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class OrderCalculationCallbacks
   {
      private bool calculateTaxRatesField;
      private bool calculateTaxRatesFieldSpecified;
      private bool calculatePromotionsField;
      private bool calculatePromotionsFieldSpecified;
      private bool calculateShippingRatesField;
      private bool calculateShippingRatesFieldSpecified;
      private string orderCallbackEndpointField;
      private bool processOrderOnCallbackFailureField;
      private bool processOrderOnCallbackFailureFieldSpecified;
      /// <remarks/>
      public bool CalculateTaxRates
      {
         get
         {
            return this.calculateTaxRatesField;
         }
         set
         {
            this.calculateTaxRatesField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool CalculateTaxRatesSpecified
      {
         get
         {
            return this.calculateTaxRatesFieldSpecified;
         }
         set
         {
            this.calculateTaxRatesFieldSpecified = value;
         }
      }
      /// <remarks/>
      public bool CalculatePromotions
      {
         get
         {
            return this.calculatePromotionsField;
         }
         set
         {
            this.calculatePromotionsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool CalculatePromotionsSpecified
      {
         get
         {
            return this.calculatePromotionsFieldSpecified;
         }
         set
         {
            this.calculatePromotionsFieldSpecified = value;
         }
      }
      /// <remarks/>
      public bool CalculateShippingRates
      {
         get
         {
            return this.calculateShippingRatesField;
         }
         set
         {
            this.calculateShippingRatesField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool CalculateShippingRatesSpecified
      {
         get
         {
            return this.calculateShippingRatesFieldSpecified;
         }
         set
         {
            this.calculateShippingRatesFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI")]
      public string OrderCallbackEndpoint
      {
         get
         {
            return this.orderCallbackEndpointField;
         }
         set
         {
            this.orderCallbackEndpointField = value;
         }
      }
      /// <remarks/>
      public bool ProcessOrderOnCallbackFailure
      {
         get
         {
            return this.processOrderOnCallbackFailureField;
         }
         set
         {
            this.processOrderOnCallbackFailureField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool ProcessOrderOnCallbackFailureSpecified
      {
         get
         {
            return this.processOrderOnCallbackFailureFieldSpecified;
         }
         set
         {
            this.processOrderOnCallbackFailureFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class ShippingAddresses
   {
      private ShippingAddress[] shippingAddressField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ShippingAddress")]
      public ShippingAddress[] ShippingAddress
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
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(TypeName="ShippingMethods", Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute("ShippingMethods", Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class ShippingMethods1
   {
      private ShippingMethod[] shippingMethodField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ShippingMethod")]
      public ShippingMethod[] ShippingMethod
      {
         get
         {
            return this.shippingMethodField;
         }
         set
         {
            this.shippingMethodField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Promotions
   {
      private Promotion[] promotionField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Promotion")]
      public Promotion[] Promotion
      {
         get
         {
            return this.promotionField;
         }
         set
         {
            this.promotionField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class TaxTables
   {
      private TaxTable[] taxTableField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("TaxTable")]
      public TaxTable[] TaxTable
      {
         get
         {
            return this.taxTableField;
         }
         set
         {
            this.taxTableField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Items
   {
      private Item[] itemField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Item")]
      public Item[] Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class MerchantUpsellItems
   {
      private MerchantUpsellItem[] merchantUpsellItemField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("MerchantUpsellItem")]
      public MerchantUpsellItem[] MerchantUpsellItem
      {
         get
         {
            return this.merchantUpsellItemField;
         }
         set
         {
            this.merchantUpsellItemField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class AmazonUpsellItems
   {
      private string[] aSINField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ASIN")]
      public string[] ASIN
      {
         get
         {
            return this.aSINField;
         }
         set
         {
            this.aSINField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class Categories
   {
      private string[] categoryField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Category")]
      public string[] Category
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
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class ShippingMethodIds
   {
      private string[] shippingMethodIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ShippingMethodId")]
      public string[] ShippingMethodId
      {
         get
         {
            return this.shippingMethodIdField;
         }
         set
         {
            this.shippingMethodIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class CartTaxAmounts
   {
      private CartTaxAmount[] cartTaxAmountField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CartTaxAmount")]
      public CartTaxAmount[] CartTaxAmount
      {
         get
         {
            return this.cartTaxAmountField;
         }
         set
         {
            this.cartTaxAmountField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class TaxRules
   {
      private TaxRule[] taxRuleField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("TaxRule")]
      public TaxRule[] TaxRule
      {
         get
         {
            return this.taxRuleField;
         }
         set
         {
            this.taxRuleField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://payments.amazon.com/checkout/2009-05-15/", IsNullable=true)]
   public  class ParameterizedUrls
   {
      private ParameterizedUrl[] parameterizedUrlField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ParameterizedUrl")]
      public ParameterizedUrl[] ParameterizedUrl
      {
         get
         {
            return this.parameterizedUrlField;
         }
         set
         {
            this.parameterizedUrlField = value;
         }
      }
   }
}
