using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Transaction : UserControl, ITransaction
{
    public Transaction()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddTransactionClicked;
    public event EventHandler? ButtonEditTransactionClicked;
    public event EventHandler? ButtonDeleteTransactionClicked;

    /// <summary>
    /// Setup editing in the form
    /// </summary>
    public void EditMode()
    {
        NumericAmount.Maximum = decimal.MaxValue;
        ButtonAddTran.Text = "Edit transaction";
        ButtonAddTran.Click += (s, e) => ButtonEditTransactionClicked?.Invoke(s, e);
        ButtonDelete.Enabled = true;
        ButtonDelete.Click += (s, e) => ButtonDeleteTransactionClicked?.Invoke(s, e);
    }

    public int TransactionId
    {
        get => Convert.ToInt32(LabelId.Text);
        set => LabelId.Text = value.ToString();
    }

    public int AccountId
    {
        get => Convert.ToInt32(ComboAccountID.SelectedItem);
        set => ComboAccountID.SelectedItem = value;
    }

    public void SetAccountOptions(List<int> accounts)
    {
        ComboAccountID.DataSource = new BindingSource(accounts, null);
    }

    public TransactionAction? Action
    {
        get
        {
            if (Enum.TryParse<TransactionAction>(ComboAction.Text.Replace(" ", ""), true, out var returnValue))
                return Enum.IsDefined(typeof(TransactionAction), returnValue) ? returnValue : null;

            return null;
        }
        set => ComboAction.Text = TransactionHelper.StringFromTransaction((TransactionAction)value);
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

    public void AddNavItems(List<BankTransaction> transactions)
    {
        SideNav.AddItem(transactions);
    }


    public void ShowResult(int result)
    {
        MessageBox.Show($"Database changed {result} rows to transaction table");
    }

    public void ShowError(string message)
    {
        MessageBox.Show(message);
    }

    private void OnTransactionLoad(object sender, EventArgs eventArgs)
    {
        NumericAmount.Maximum = decimal.MaxValue;
        ButtonAddTran.Click += (s, e) => ButtonAddTransactionClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeTransactions") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeTransactions");
    }
}
