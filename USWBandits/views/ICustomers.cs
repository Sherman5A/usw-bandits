using USWBandits.components;

namespace USWBandits.views;

public interface ICustomers : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustClick;
}
