using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Transactions : UserControl, IProducts
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Transactions()
    {
        InitializeComponent();
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeTransactions") TreeNavSelect?.Invoke(s, e);
        };
    }

    private void OnTransactionsLoad(object sender, EventArgs e)
    {
        SideNav.FocusNode("NodeTransactions");
    }
}
