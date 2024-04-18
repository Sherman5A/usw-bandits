using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class TotalDepWith : UserControl, ITotalDepWith
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonStartQuery;

    public TotalDepWith()
    {
        InitializeComponent();
    }

    private void OnTotalDepWithLoad(object sender, EventArgs eventArgs)
    {
        ButtonSearch.Click += (s, e) => ButtonStartQuery?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeTransactions") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeTransactions");
    }

    public void ShowResult(int addResult)
    {
        MessageBox.Show($"Database added {addResult} rows");
    }

    public DateTime LowerDate { get => DateFrom.Value; set => DateFrom.Value = value; }
    public DateTime UpperDate { get => DateTo.Value; set => DateTo.Value = value; }
    public TransactionAction? TransactionAction
    {
        get
        {
            if (Enum.TryParse<TransactionAction>(ComboTransactionType.Text.Replace(" ", ""), true, out var returnValue))
            {
                return Enum.IsDefined(typeof(TransactionAction), returnValue) ? returnValue : null;
            }

            return null;
        }
        set => ComboTransactionType.Text = TransactionHelper.StringFromTransaction((TransactionAction)value);
    }
            
    public void AddTransactions(List<BankAccount> accounts)
    {
        throw new NotImplementedException();
    }
}
