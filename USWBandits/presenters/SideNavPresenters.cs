using System.Diagnostics;
using USWBandits.components;
using USWBandits.views;

namespace USWBandits.presenters;

public abstract class SideNavPresenters : IPresenter
{
    public abstract Control ParentControl { get; set; }
    public abstract UserControl ViewControl { get; }

    public void OnTreeNavSelect(object? sender, TreeNavSelectArgs e)
    {
        IPresenter? nextPresenter = e.SelectedNode switch
        {
            "NodeHome" => new HomePresenter(ParentControl, new Home()),
            "NodeProducts" => new ProductsPresenter(ParentControl, new Products()),
            "NodeAccounts" => new AccountsPresenter(ParentControl, new Accounts()),
            "NodeCustomers" => null,
            "NodeTransactions" => null,
            _ => null
        };
        if (nextPresenter != null) ChangePresenter(nextPresenter);
    }

    public abstract void ChangePresenter(IPresenter presenter);
}
