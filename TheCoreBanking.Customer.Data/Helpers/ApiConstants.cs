namespace TheCoreBanking.Customer.Data.Helpers
{
    public class ApiConstants
    {
       // public const string BaseApiUrl = "http://bankingplatform:8042/";
        public const string BaseApiUrlDev = "http://localhost:22669/";
        public const string ChartOfAccountEndpoint = "Finances/Chart/ListChart";
        //public const string CurrencyEndpoint = "Finances/financeSetup/ListCurrency";
       // public const string ProductEndpoint = "Product/ProductMapping/ListProduct";
        public const string ProductEndpointDev = "ProductMapping/ListProduct";
      //  public const string ProductFeeListEndpoint = "Product/productsetup/listproductFees";
        public const string ProductFeeListEndpointDev = "productsetup/listproductFees";
     //   public const string ProductFeeLinkToAccountEndpoint = "Product/productmapping/GetFeeNameByProductName";
        public const string ProductFeeLinkToAccountEndpointDev = "productmapping/GetFeeNameByProductName";
      //  public const string ProductFeeLinkToAccountExtraEndpoint = "Product/productmapping/GetExtraFeeNameByProductName";
        public const string ProductFeeLinkToAccountExtraEndpointDev = "productmapping/GetExtraFeeNameByProductName";
       // public const string UserEndpoint = "Administration/ListUsers";
        public const string CompanyEndpoint = "company/companysetup/listcompany";
        public const string BranchEndpoint = "company/companysetup/listbranch";
        public const string LoanBookingEndpoint = "credits/creditsetup/listloanlease";
        public const string CASAEndpoint = "Customer/Account/ListAccountNoMapDetails";
        public const string CurrentAccountEndpoint = "Customer/Account/ListCurrentAccounts";
        public const string ChequeAccountEndpoint = "Customer/Account/ListChequeAccounts";
        public const string CASAMandateEndpoint = "Customer/Account/GetMandatesByAccNo";
        public const string CASAMandateDocListEndpoint = "Customer/Account/LoadMandateFiles";
        public const string CASAMandateDocEndpoint = "Customer/Account/LoadMandateDocument";

        // for Azure Product
        public const string BaseApiUrl = "http://fintrakbankingmmbs-product.azurewebsites.net/";
        public const string ProductEndpoint = "ProductMapping/ListProduct";
        public const string ProductFeeListEndpoint = "productsetup/listproductFees";
        public const string ProductFeeLinkToAccountEndpoint = "productmapping/GetFeeNameByProductName";
        public const string ProductFeeLinkToAccountExtraEndpoint = "productmapping/GetExtraFeeNameByProductName";
        public const string BaseApiUrlCurrency = "http://fintrakbankingmmbs-finance.azurewebsites.net/";
        public const string CurrencyEndpoint = "financeSetup/ListCurrency";
        public const string BaseApiUrlAdministration = "http://fintrakbankingmmbs.azurewebsites.net/";
        public const string UserEndpoint = "Administration/ListUsers";

        //Others
        /* public const string ChartOfAccountEndpoint = "Finances/Chart/ListChart";
         public const string CurrencyEndpoint = "Finances/financeSetup/ListCurrency";
         public const string UserEndpoint = "Administration/ListUsers";
         public const string CompanyEndpoint = "company/companysetup/listcompany";
         public const string BranchEndpoint = "company/companysetup/listbranch";
         public const string LoanBookingEndpoint = "credits/creditsetup/listloanlease";
         public const string CASAEndpoint = "Customer/Account/ListAccountNoMapDetails";
         public const string CurrentAccountEndpoint = "Customer/Account/ListCurrentAccounts";
         public const string ChequeAccountEndpoint = "Customer/Account/ListChequeAccounts";
         public const string CASAMandateEndpoint = "Customer/Account/GetMandatesByAccNo";
         public const string CASAMandateDocListEndpoint = "Customer/Account/LoadMandateFiles";
         public const string CASAMandateDocEndpoint = "Customer/Account/LoadMandateDocument";*/
    }
}
