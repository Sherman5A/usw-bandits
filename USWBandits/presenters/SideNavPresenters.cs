using USWBandits.components;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public abstract class SideNavPresenters : IPresenter
{
    public abstract ModelData ModelData { get; }
    public abstract Control ParentControl { get; set; }
    public abstract UserControl ViewControl { get; }

    public abstract void ChangePresenter(IPresenter presenter);

    public void OnTreeNavSelect(object? sender, TreeNavSelectArgs e)
    {
        // Get the selected node and route where to swap view to
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
        if (nextPresenter != null)
        {
            // If none of the parent views are selected, use child view function
            ChangePresenter(nextPresenter);
            return;
        }

        HandleChildSelected(e.SelectedNode);
    }

    private void HandleChildSelected(string nodeName)
    {
        // Split the name of child nodes into their View and db row number
        var splitNode = nodeName.Split("-");
        var tableType = splitNode[0];
        var tableKey = Convert.ToInt32(splitNode[1]);
        // Route to any child views
        IPresenter? nextPresenter = tableType switch
        {
            "Account" => new AccountPresenter(ParentControl, new Account(), ModelData, tableKey),
            "Product" => new ProductPresenter(ParentControl, new Product(), ModelData, tableKey),
            "Transaction" => new TransactionPresenter(ParentControl, new Transaction(), ModelData, tableKey),
            "Customer" => new CustomerPresenter(ParentControl, new Customer(), ModelData, tableKey),
            _ => null
        };
        // If no nodes were clicked, do nothing
        if (nextPresenter != null) ChangePresenter(nextPresenter);
    }
}
