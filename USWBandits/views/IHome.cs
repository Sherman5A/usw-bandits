using USWBandits.components;

namespace USWBandits.views;

public interface IHome : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler ButtonCustomersClick;
    public event EventHandler ButtonTransactionsClick;
    public event EventHandler ButtonAccountsClick;
    public event EventHandler ButtonProductsClick;
}
