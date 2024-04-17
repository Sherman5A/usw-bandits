using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

/// <summary>
/// Contract that must be enforced between Transaction and TransactionPresenter
/// </summary>
public interface ITransaction : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler ButtonAddTransactionClicked;
    public event EventHandler? ButtonDeleteTransactionClicked;
    public event EventHandler? ButtonEditTransactionClicked;
    decimal Amount { get; set; }
    DateTime TransactionEvent { get; set; }
    TransactionAction? Action { get; set; }
    int TransactionId { get; set; }
    int AccountId { get; set; }
    void ShowResult(int result);
    void SetAccountOptions(List<int> accounts);
    void ShowError(string message);
    void EditMode();
    void AddNavItems(List<BankTransaction> transactions);
}
