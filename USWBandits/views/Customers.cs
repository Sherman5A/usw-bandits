using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Customers : UserControl, ICustomers
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustClick;

    public Customers()
    {
        InitializeComponent();
    }

    private void OnCustomersLoad(object sender, EventArgs eventArgs)
    {
        ButtonAddCustomer.Click += (s, e) => ButtonAddCustClick?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeCustomers") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeCustomers");
    }
}
