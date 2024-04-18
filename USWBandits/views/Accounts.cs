using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Accounts : UserControl, IAccounts
{
    public Accounts()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonNewAccountClick;

    private void OnAccountsLoad(object sender, EventArgs eventArgs)
    {
        ButtonAddAccount.Click += (s, e) => ButtonNewAccountClick?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeAccounts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeAccounts");
    }
}
