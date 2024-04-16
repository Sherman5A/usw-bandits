namespace USWBandits.logic;

public enum TransactionAction
{
    TransferIn,
    TransferOut,
    Deposit,
    Withdraw,
}

public class TransactionHelper
{
    public static string? StringFromTransaction(TransactionAction action)
    {
        switch (action)
        {
            case TransactionAction.TransferIn:
                return "transfer in";
            case TransactionAction.TransferOut:
                return "transfer out";
            case TransactionAction.Deposit:
                return "deposit";
            case TransactionAction.Withdraw:
                return "widthdraw";
            default:
                return null;
        }
    }
}
