using USWBandits.components;

namespace USWBandits.views;

public interface IAccount : IView
{

    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? AddAccountClicked;
    void SetAccountID(int accID);
    void SetCustomerOptions(List<(int id, string firstName, string lastName)> list);
    int GetCustomerID();
    void SetProductOptions(List<(int id, string isaName)> list);
    int GetProductID();
    decimal Accrued { get; set; }
    decimal Balance { get; set; }
}
