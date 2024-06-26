﻿namespace USWBandits.logic;

public class BankTransaction
{
    public BankTransaction(int transactionId, int tranAccountId, TransactionAction action, decimal amount,
        DateTime dateEvent)
    {
        TransactionID = transactionId;
        TranAccountID = tranAccountId;
        Action = action;
        Amount = amount;
        Event = dateEvent;
    }

    public BankTransaction(int transactionId, int tranAccountId, string action, decimal amount,
        DateTime dateEvent)
    {
        TransactionID = transactionId;
        TranAccountID = tranAccountId;
        // Try to convert the string into an enum
        if (Enum.TryParse<TransactionAction>(action.Replace(" ", ""), true, out var returnValue))
            // Check that the new enum is actually a member of TransactionAction, if not set it to a default value
            Action = Enum.IsDefined(typeof(TransactionAction), returnValue) ? returnValue : TransactionAction.Deposit;

        Amount = amount;
        Event = dateEvent;
    }

    public int TransactionID { get; }
    public int TranAccountID { get; }
    public TransactionAction Action { get; }
    public decimal Amount { get; }
    public DateTime Event { get; }

    public string? GetActionString()
    {
        return TransactionHelper.StringFromTransaction(Action);
    }
}
