namespace TheCoreBanking.Customer.ViewModels
{
    public class ProductVM
    {
        public int ID;
        public string ProductCode;
        public string ProductName;
        public string ProductDescription;
        public ProductTypeVM ProductType;
        public decimal MinimumBalance;
        public decimal MinimumRate;
        public decimal MaximumRate;
        public decimal MinimumTenor;
        public decimal MaximumTenor;
    }

    public class ProductTypeVM
    {
        public int PdTypeID;
        public string PdType;
    }
}
