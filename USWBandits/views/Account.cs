using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Account : UserControl, IAccount
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddAccountClicked;

    public Account()
    {
        InitializeComponent();
    }

    private void OnAccountLoad(object sender, EventArgs eventArgs)
    {
        NumericBalance.Maximum = decimal.MaxValue;
        NumericAccrued.Maximum = decimal.MaxValue;
        ButtonAdd.Click += (s, e) => ButtonAddAccountClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeAccounts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeAccounts");
    }

    public void SetAccountId(int accID)
    {
        LabelAccountID.Text = accID.ToString();
    }

    public void SetCustomerOptions(List<(int id, string firstName, string lastName)> customers)
    {
        Dictionary<int, string> optionsDict = new();
        foreach (var (id, firstName, lastName) in customers)
        {
            optionsDict.Add(id, $"ID: {id} - {firstName} {lastName}");
        }

        ComboCustomerID.DataSource = new BindingSource(optionsDict, null);
        ComboCustomerID.DisplayMember = "Value";
        ComboCustomerID.ValueMember = "Key";
    }

    public int GetCustomerID() => ((KeyValuePair<int, string>)ComboCustomerID.SelectedItem).Key;

    public void SetProductOptions(List<(int id, string isaName)> products)
    {
        Dictionary<int, string> optionsDict = new();
        foreach (var (id, isaName) in products)
        {
            optionsDict.Add(id, $"ID: {id} - {isaName}");
        }

        ComboProductID.DataSource = new BindingSource(optionsDict, null);
        ComboProductID.DisplayMember = "Value";
        ComboProductID.ValueMember = "Key";
    }

    public void ShowResult(int addResult)
    {
        MessageBox.Show($"Database added {addResult} rows");
    }

    public void AddNavItems(List<BankAccount> accounts) => SideNav.AddItem(accounts);

    public decimal Balance
    {
        get => NumericBalance.Value;
        set => NumericBalance.Value = value;
    }

    public decimal Accrued
    {
        get => NumericAccrued.Value;
        set => NumericAccrued.Value = value;
    }

    public int GetProductID() => ((KeyValuePair<int, string>)ComboProductID.SelectedItem).Key;
}
