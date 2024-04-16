using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

public interface ITransaction : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler ButtonAddTransactionClicked;
    decimal Amount { get; set; }
    TransactionAction GetAction();
    DateTime GetEvent();
    void ShowResult(int result);
    int GetAccountId();
    void SetAccountOptions(List<int> accounts);
}
