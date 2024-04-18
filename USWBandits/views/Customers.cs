using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Customers : UserControl, ICustomers
{
    public Customers()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustClick;

    public void AddNavItems(List<BankCustomer> customers)
    {
        SideNav.AddItem(customers);
    }

    private void OnCustomersLoad(object sender, EventArgs eventArgs)
    {
        // Pass event up
        ButtonAddCustomer.Click += (s, e) => ButtonAddCustClick?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeCustomers") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeCustomers");
    }
}
