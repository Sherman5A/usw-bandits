using USWBandits.components;

namespace USWBandits.views;

public interface ICustomersByHoldings : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonStartQuery;
}
