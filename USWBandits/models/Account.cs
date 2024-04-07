namespace USWBandits.models;

public class Account
{
    // DB Info
    public int AccID { get; }
    public int AccCustomerID { get; }
    public Customer AccCustomer { get; set; }
    public int AccProductID { get; }
    public Product AccProduct { get; set; }
    public decimal AccBalance { get; }
    public decimal AccAccrued { get; }
}
