using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Customer : UserControl, ICustomer
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Customer()
    {
        InitializeComponent();
    }

    private void OnCustomerLoad(object sender, EventArgs eventArgs)
    {
        NumericAllowance.Maximum = decimal.MaxValue;
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeCustomers") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeCustomers");
    }
}
