using USWBandits.components;

namespace USWBandits.views;

public interface ICustomersByHoldings : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? StartQuery;
    List<(int customerId, string firstName, string lastName, decimal balance)> Customers { set; }
}
