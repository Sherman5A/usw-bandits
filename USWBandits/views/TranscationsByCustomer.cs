using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class TransactionsByCustomer : UserControl, ITransactionsByCustomer
{
    public TransactionsByCustomer()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonStartQuery;

    public int CustomerId => ((KeyValuePair<int, string>)ComboCustomerId.SelectedItem).Key;

    public List<(int customer, string firstName, string lastName)> ComboCustomers
    {
        set
        {
            Dictionary<int, string> listParing = new();

            foreach (var (customerKey, firstName, lastName) in value)
                listParing.Add(customerKey,
                    $"ID: {customerKey} Name: {firstName} {lastName}");

            ComboCustomerId.DataSource = new BindingSource(listParing, null);
            ComboCustomerId.DisplayMember = "Value";
            ComboCustomerId.ValueMember = "Key";
        }
    }

    public void ShowTransactions(List<BankTransaction> transactions)
    {
        ListCustomers.Items.Clear();
        foreach (var transaction in transactions)
            ListCustomers.Items.Add(
                $"Date: {transaction.Event} Account: {transaction.TranAccountID} Action: {transaction.GetActionString()} Amount: {transaction.Amount}");
    }

    private void OnCustomersLoad(object sender, EventArgs eventArgs)
    {
        ButtonSearch.Click += ButtonSearchClicked;
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeStats") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeStats");
    }

    private void ButtonSearchClicked(object sender, EventArgs e)
    {
        ButtonStartQuery?.Invoke(this, EventArgs.Empty);
    }
}
