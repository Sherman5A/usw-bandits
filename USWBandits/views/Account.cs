using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Account : UserControl, IAccount
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Account()
    {
        InitializeComponent();
    }

    private void OnAccountLoad(object sender, EventArgs e)
    {
        NumericBalance.Maximum = decimal.MaxValue;
        NumericAccrued.Maximum = decimal.MaxValue;
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeAccounts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeAccounts");
    }
}
