using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Account : UserControl, IAccount
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? AddAccountClicked;

    public Account()
    {
        InitializeComponent();
    }

    private void OnAccountLoad(object sender, EventArgs eventArgs)
    {
        NumericBalance.Maximum = decimal.MaxValue;
        NumericAccrued.Maximum = decimal.MaxValue;
        ButtonUpdate.Click += (s, e) => AddAccountClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeAccounts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeAccounts");
    }

    public void SetAccountID(int accID)
    {
        LabelAccountID.Text = accID.ToString();
    }

    public void SetCustomerOptions(List<(int id, string firstName, string lastName)> list)
    {
        Dictionary<int, string> optionsDict = new();
        foreach (var item in list)
        {
            optionsDict.Add(item.id, $"ID: {item.id} - {item.firstName} {item.lastName}");
        }
        ComboCustomerID.DataSource = new BindingSource(optionsDict, null);
        ComboCustomerID.DisplayMember = "Value";
        ComboCustomerID.ValueMember = "Key";
    }
    public int GetCustomerID() => ((KeyValuePair<int, string>)ComboCustomerID.SelectedItem).Key;

    public void SetProductOptions(List<(int id, string isaName)> list)
    {
        Dictionary<int, string> optionsDict = new();
        foreach (var item in list)
        {
            optionsDict.Add(item.id, $"ID: {item.id} - {item.isaName}");
        }
        ComboProductID.DataSource = new BindingSource(optionsDict, null);
        ComboProductID.DisplayMember = "Value";
        ComboProductID.ValueMember = "Key";
    }

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
