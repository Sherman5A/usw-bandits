using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

public interface IAccount : IView
{
    decimal Accrued { get; set; }
    decimal Balance { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddAccountClicked;
    void SetAccountId(int accID);
    void SetCustomerOptions(List<(int id, string firstName, string lastName)> customers);
    int GetCustomerID();
    void SetProductOptions(List<(int id, string isaName)> products);
    int GetProductID();
    void ShowResult(int addResult);
    void AddNavItems(List<BankAccount> accounts);
}
