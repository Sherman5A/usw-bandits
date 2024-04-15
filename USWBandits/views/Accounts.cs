using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Accounts : UserControl, IAccounts
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonNewAccountClick;
    public IPresenter? Presenter { get; set; }

    public Accounts()
    {
        InitializeComponent();
    }

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
