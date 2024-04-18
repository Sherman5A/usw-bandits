using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

/// <summary>
///     Contract between Account and AccountPresenter
/// </summary>
public interface IAccount : IView
{
    decimal Accrued { get; set; }
    decimal Balance { get; set; }
    int CustomerId { get; set; }
    int ProductId { get; set; }
    int AccountId { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddAccountClicked;
    public event EventHandler? ButtonEditAccountClicked;
    public event EventHandler? ButtonDeleteAccountClicked;
    void SetCustomerOptions(List<int> customers);
    void SetProductOptions(List<int> products);
    void ShowResult(int addResult);
    void AddNavItems(List<BankAccount> accounts);
    void ShowError(string transactionDoesNotExist);
    void EditMode();
}
