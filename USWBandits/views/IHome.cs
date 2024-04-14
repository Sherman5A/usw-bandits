using USWBandits.components;

namespace USWBandits.views;

public interface IHome : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler ButtonCustomersClick;
    public event EventHandler ButtonTransactionClick;
    public event EventHandler ButtonAccountsClick;
    public event EventHandler ButtonProductsClick;
}
