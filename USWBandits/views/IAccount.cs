using USWBandits.components;

namespace USWBandits.views;

public interface IAccount : IView
{
    decimal Accrued { get; set; }
    decimal Balance { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddAccountClicked;
    void SetAccountID(int accID);
    void SetCustomerOptions(List<(int id, string firstName, string lastName)> list);
    int GetCustomerID();
    void SetProductOptions(List<(int id, string isaName)> list);
    int GetProductID();
    void ShowResult(int addResult);
}
