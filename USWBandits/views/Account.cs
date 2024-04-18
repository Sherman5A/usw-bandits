using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Account : UserControl, IAccount
{
    public Account()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddAccountClicked;
    public event EventHandler? ButtonEditAccountClicked;
    public event EventHandler? ButtonDeleteAccountClicked;

    public void SetCustomerOptions(List<int> customers)
    {
        ComboCustomerID.DataSource = new BindingSource(customers, null);
    }

    public void SetProductOptions(List<int> products)
    {
        ComboProductID.DataSource = new BindingSource(products, null);
    }

    public void ShowResult(int addResult)
    {
        MessageBox.Show($"Database added {addResult} rows");
    }

    public void AddNavItems(List<BankAccount> accounts)
    {
        SideNav.AddItem(accounts);
    }

    public void ShowError(string message)
    {
        MessageBox.Show(message);
    }

    /// <summary>
    /// Change view variables for editing
    /// </summary>
    public void EditMode()
    {
        // Set numeric to their limits
        NumericBalance.Maximum = decimal.MaxValue;
        NumericAccrued.Maximum = decimal.MaxValue;
        ButtonAdd.Text = "Edit transaction";
        ButtonAdd.Click += (s, e) => ButtonEditAccountClicked?.Invoke(s, e);
        ButtonDelete.Enabled = true;
        ButtonDelete.Click += (s, e) => ButtonDeleteAccountClicked?.Invoke(s, e);
    }

    public decimal Balance
    {
        get => NumericBalance.Value;
        set => NumericBalance.Value = value;
    }

    public int AccountId
    {
        get =>
            Convert.ToInt32(LabelAccountID.Text);
        set => LabelAccountID.Text = value.ToString();
    }

    public int ProductId
    {
        get => Convert.ToInt32(ComboProductID.SelectedItem);
        set => ComboProductID.SelectedItem = value;
    }

    public int CustomerId
    {
        get => Convert.ToInt32(ComboCustomerID.SelectedItem);
        set => ComboCustomerID.SelectedItem = value;
    }

    public decimal Accrued
    {
        get => NumericAccrued.Value;
        set => NumericAccrued.Value = value;
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
}
