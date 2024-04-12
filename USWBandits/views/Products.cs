namespace USWBandits.views;

public partial class Products : ConnectedView, IProducts
{
    
    public Products()
    {
        InitializeComponent();
    }

    private void OnProductsLoad(object sender, EventArgs e)
    {
        sideNav.FocusNode("NodeAccounts");
    }
}