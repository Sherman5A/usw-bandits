using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

public interface ITransaction : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler ButtonAddTransactionClicked;
    decimal Amount { get; set; }
    DateTime TransactionEvent { get; set; }
    TransactionAction? GetAction();
    void ShowResult(int result);
    int GetAccountId();
    void SetAccountOptions(List<int> accounts);
    void ShowError(string message);
    void SetTransactionId(int accID);
}
