using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class CustomersByHoldings: UserControl, ICustomersByHoldings
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonStartQuery;

    public CustomersByHoldings()
    {
        InitializeComponent();
    }

    private void OnCustomersLoad(object sender, EventArgs eventArgs)
    {
        ButtonStartQuery?.Invoke(this, EventArgs.Empty);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeCustomers") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeCustomers");
    }

    public void ShowResult(int addResult)
    {
        MessageBox.Show($"Database added {addResult} rows");
    }

    public List<(int customer, string firstName, string lastName, decimal balance)> Customers
    {
        set
        {
            Dictionary<(int customer, string firstName, string lastName, decimal balance), string> listParing = new();

            foreach (var (customer, firstName, lastName, balance) in value)
            {
                listParing.Add((customer, firstName, lastName, balance), $"ID: {customer} Name: {firstName} {lastName} {balance}");
            }
        }
    }
}
