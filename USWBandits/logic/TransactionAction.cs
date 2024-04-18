namespace USWBandits.logic;

public enum TransactionAction
{
    TransferIn,
    TransferOut,
    Deposit,
    Withdraw
}

public class TransactionHelper
{
    /// <summary>
    ///     Return string values of enums to match database format
    /// </summary>
    /// <param name="action">Enum</param>
    /// <returns>
    ///     Formatted string of enum.
    ///     Null if the enum was not matched
    /// </returns>
    public static string? StringFromTransaction(TransactionAction action)
    {
        return action switch
        {
            TransactionAction.TransferIn => "transfer in",
            TransactionAction.TransferOut => "transfer out",
            TransactionAction.Deposit => "deposit",
            TransactionAction.Withdraw => "widthdraw",
            _ => null
        };
    }
}
