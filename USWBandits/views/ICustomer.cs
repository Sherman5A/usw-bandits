using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

/// <summary>
///     Contract between Customer and CustomerPresenter
/// </summary>
public interface ICustomer : IView
{
    decimal Allowance { get; set; }
    int CustomerId { get; set; }
    string Title { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    DateOnly CustomerDob { get; set; }
    string NiNumber { get; set; }
    string Email { get; set; }
    string Password { get; set; }
    public event EventHandler? ButtonEditCustomerClicked;
    public event EventHandler? ButtonDeleteCustomerClicked;
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustomerClicked;
    void ShowResult(int result);
    void AddNavItems(List<BankCustomer> customers);
    void ShowError(string transactionDoesNotExist);
    void EditMode();
}
