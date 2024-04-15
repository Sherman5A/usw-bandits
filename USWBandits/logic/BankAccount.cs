namespace USWBandits.logic;

public class BankAccount
{
    public int AccountID { get; }
    public int CustomerID { get; }
    public BankCustomer Customer { get; set; }
    public int ProductID { get; }
    public BankProduct Product { get; set; }
    public decimal Balance { get; }
    public decimal Accrued { get; }

    public BankAccount(int accountId, int customerId, int productId, decimal balance, decimal accrued)
    {
        AccountID = accountId;
        CustomerID = customerId;
        ProductID = productId;
        Balance = balance;
        Accrued = accrued;
    }
}
