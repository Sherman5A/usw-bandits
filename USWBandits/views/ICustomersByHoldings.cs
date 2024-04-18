using USWBandits.components;

namespace USWBandits.views;

public interface ICustomersByHoldings : IView
{
    List<(int customerId, string firstName, string lastName, decimal balance)> Customers { set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? StartQuery;
}
