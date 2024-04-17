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
        DateTransactionEvent.CustomFormat = "yyyy:MM:dd HH:mm";
        NumericAmount.Maximum = decimal.MaxValue;
        ButtonAddTran.Click += (s, e) => ButtonAddTransactionClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeTransactions") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeTransactions");
    }

    public void SetTransactionId(int accID)
    {
        LabelId.Text = accID.ToString();
    }

    public void SetAccountOptions(List<int> accounts)
    {
        ComboAccountID.DataSource = new BindingSource(accounts, null);
    }

    public TransactionAction? GetAction()
    {
        if (Enum.TryParse<TransactionAction>(ComboAction.Text.Replace(" ", ""), true, out var returnValue))
        {
            return Enum.IsDefined(typeof(TransactionAction), returnValue) ? returnValue : null;
        }
        return null;
    }

    public decimal Amount
    {
        get => NumericAmount.Value;
        set => NumericAmount.Value = value;
    }

    public DateTime TransactionEvent
    {
        get => DateTransactionEvent.Value;
        set => DateTransactionEvent.Value = value;
    }

    public void ShowResult(int result)
    {
        MessageBox.Show($"Database added {result} rows to transaction table");
    }

    public void ShowError(string message)
    {
        MessageBox.Show(message);
    }

    public int GetAccountId() => Convert.ToInt32(ComboAccountID.SelectedItem);
}
