using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

/// <summary>
///     Contract between Accounts and AccountsPresenter
/// </summary>
public interface IAccounts : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonNewAccountClick;
    void AddNavItems(List<BankAccount> accounts);
}
