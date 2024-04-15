namespace USWBandits.logic;

public class BankTransaction
{
    public int TransactionID { get; }
    public int TranAccountID { get; }
    public BankAccount TranAccount { get; set; }
    public TransactionAction TranAction { get; }
    public decimal Amount { get; }
    public DateTime TranTime { get; }
}
