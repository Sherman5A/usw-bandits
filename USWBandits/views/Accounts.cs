using USWBandits.components;
using USWBandits.logic;
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

    public void AddNavItems(List<BankAccount> accounts)
    {
        SideNav.AddItem(accounts);
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
