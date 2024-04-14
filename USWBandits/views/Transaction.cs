using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Transaction : UserControl, ITransaction
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

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
}
