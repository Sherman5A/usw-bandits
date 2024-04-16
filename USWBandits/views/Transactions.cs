using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Transactions : UserControl, ITransactions
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddTransactionClick;

    public Transactions()
    {
        InitializeComponent();
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
