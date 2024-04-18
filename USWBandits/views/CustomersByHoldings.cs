using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class CustomersByHoldings : UserControl, ICustomersByHoldings
{
    public CustomersByHoldings()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? StartQuery;

    public List<(int customerId, string firstName, string lastName, decimal balance)> Customers
    {
        set
        {
            Dictionary<(int customerId, string firstName, string lastName, decimal balance), string> listParing = new();

            foreach (var (customerId, firstName, lastName, balance) in value)
                listParing.Add((customerId, firstName, lastName, balance),
                    $"ID: {customerId} Name: {firstName} {lastName} Total Balance: {balance}");

            ListCustomers.DataSource = new BindingSource(listParing, null);
            ListCustomers.DisplayMember = "Value";
            ListCustomers.ValueMember = "Key";
        }
    }

    private void OnCustomersLoad(object sender, EventArgs eventArgs)
    {
        // Start query when first loaded as there is no user input
        StartQuery?.Invoke(this, EventArgs.Empty);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeStats") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeStats");
    }
}
