using USWBandits.components;

namespace USWBandits.views;

public interface ICustomer : IView
{
    decimal Allowance { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustomersClicked;
    string GetCustomerTitle();
    DateOnly GetDateBirth();
    string GetEmail();
    string GetFirstName();
    string GetLastName();
    string GetNiNumber();
    string GetPassword();
    void SetCustomerId(int v);
    void ShowResult(int result);
}
