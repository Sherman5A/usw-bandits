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
        return action switch
        {
            TransactionAction.TransferIn => "transfer in",
            TransactionAction.TransferOut => "transfer out",
            TransactionAction.Deposit => "deposit",
            TransactionAction.Withdraw => "widthdraw",
            _ => null,
        };
    }
}
