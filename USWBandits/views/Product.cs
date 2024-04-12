namespace USWBandits.views;

public partial class Product : ConnectedView, IProduct
{
    public Product()
    {
        InitializeComponent();
    }

    private void OnProductsLoad(object sender, EventArgs e)
    {
        sideNav.FocusNode("NodeAccounts");
    }
}
