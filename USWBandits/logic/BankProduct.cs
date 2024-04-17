namespace USWBandits.logic;

public class BankProduct
{
    public int ProductID { get; }
    public string AccountName { get; }
    public ProductOpenStatus ProductStatus { get; }
    public int ProductInterest { get; }


    public BankProduct(int productId, string accountName, ProductOpenStatus productStatus, int productInterest)
    {
        ProductID = productId;
        AccountName = accountName;
        ProductStatus = productStatus;
        ProductInterest = productInterest;
    }

    public BankProduct(int productId, string accountName, string productStatus, int productInterest)
    {
        ProductID = productId;
        AccountName = accountName;
        Enum.TryParse<ProductOpenStatus>(productStatus, out var enumOut);
        ProductStatus = Enum.IsDefined(typeof(ProductOpenStatus), enumOut) ? enumOut : ProductOpenStatus.Open;
        ProductInterest = productInterest;
    }
}
