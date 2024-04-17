using USWBandits.components;

namespace USWBandits.views;

/// <summary>
/// Contract between Customers and CustomersPresenter
/// </summary>
public interface ICustomers : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustClick;
}
