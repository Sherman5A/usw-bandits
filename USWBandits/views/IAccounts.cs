using USWBandits.components;

namespace USWBandits.views;

public interface IAccounts : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    event EventHandler? ButtonAddCustomer;
}
