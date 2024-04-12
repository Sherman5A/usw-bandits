namespace USWBandits.views;

public partial class Accounts : ConnectedView, IAccounts
{
    
    public Accounts()
    {
        InitializeComponent();
    }

    private void OnAccountsLoad(object sender, EventArgs e)
    {
        sideNav.FocusNode("NodeAccounts");
    }
}
