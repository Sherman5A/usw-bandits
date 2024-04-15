using USWBandits.components;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public abstract class SideNavPresenters : IPresenter
{
    public abstract Control ParentControl { get; set; }
    public abstract UserControl ViewControl { get; }
    public abstract ModelData ModelData { get; }

    public void OnTreeNavSelect(object? sender, TreeNavSelectArgs e)
    {
        IPresenter? nextPresenter = e.SelectedNode switch
        {
            "NodeHome" => new HomePresenter(ParentControl, new Home(), ModelData),
            "NodeProducts" => new ProductsPresenter(ParentControl, new Products(), ModelData),
            "NodeAccounts" => new AccountsPresenter(ParentControl, new Accounts(), ModelData),
            "NodeCustomers" => new CustomersPresenter(ParentControl, new Customers(), ModelData),
            "NodeTransactions" => new TransactionsPresenter(ParentControl, new Transactions(), ModelData),
            "NodeStats" => new StatsPresenter(ParentControl, new Stats(), ModelData),
            _ => null
        };
        if (nextPresenter != null) ChangePresenter(nextPresenter);
    }

    public abstract void ChangePresenter(IPresenter presenter);
}
