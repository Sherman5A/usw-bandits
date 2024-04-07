namespace USWBandits.models;

public class Transaction
{
    public int TranID { get; }
    public int TranAccountID { get; }
    public Account TranAccount { get; set; }
    public TransactionAction TranAction { get; }
    public decimal TranAmmount { get; }
    public DateTime TranTime { get; }
}
