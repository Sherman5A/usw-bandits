namespace USWBandits.logic;

public class BankTransaction
{
    public int TransactionID { get; }
    public int TranAccountID { get; }
    public BankAccount TranAccount { get; set; }
    public TransactionAction Action { get; }
    public decimal Amount { get; }
    public DateTime Event { get; }

    public BankTransaction(int transactionID, int tranAccountID, TransactionAction action, decimal amount,
        DateTime @event)
    {
        TransactionID = transactionID;
        TranAccountID = tranAccountID;
        Action = action;
        Amount = amount;
        Event = @event;
    }

    public string? GetActionString()
    {
        return TransactionHelper.StringFromTransaction(Action);
    }
}
