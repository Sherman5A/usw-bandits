namespace USWBandits.logic;

public class BankAccount
{
    public int AccountID { get; }
    public int CustomerID { get; }
    public int ProductID { get; }
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
