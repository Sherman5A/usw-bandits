namespace USWBandits.views;

public partial class Transactions : ConnectedView, IProducts
{
    
    public Transactions()
    {
        InitializeComponent();
    }

    private void OnProductsLoad(object sender, EventArgs e)
    {
        sideNav.FocusNode("NodeAccounts");
    }
}