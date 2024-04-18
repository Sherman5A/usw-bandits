using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Transactions : UserControl, ITransactions
{
    public Transactions()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddTransactionClick;

    public void AddNavItems(List<BankTransaction> transactions)
    {
        SideNav.AddItem(transactions);
    }

    private void OnTransactionsLoad(object sender, EventArgs eventArgs)
    {
        ButtonAddTransaction.Click += (s, e) => ButtonAddTransactionClick?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeTransactions") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeTransactions");
    }
}
