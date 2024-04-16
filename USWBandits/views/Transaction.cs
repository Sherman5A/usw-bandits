using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Transaction : UserControl, ITransaction
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddTransactionClicked;

    public Transaction()
    {
        InitializeComponent();
    }

    private void OnTransactionLoad(object sender, EventArgs eventArgs)
    {
        NumericAmount.Maximum = decimal.MaxValue;
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeTransactions") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeTransactions");
    }

    public void SetAccountOptions(List<int> accounts)
    {
        ComboAccountID.DataSource = new BindingSource(accounts, null);
    }

    public TransactionAction GetAction()
    {
        throw new NotImplementedException();
    }

    public decimal Amount
    {
        get => NumericAmount.Value;
        set => NumericAmount.Value = value;
    }

    public DateTime GetEvent()
    {
        throw new NotImplementedException();
    }

    public void ShowResult(int result)
    {
        MessageBox.Show($"Database added {result} rows to transaction table");
    }

    public int GetAccountId() => Convert.ToInt32(ComboAccountID.SelectedItem);
}
