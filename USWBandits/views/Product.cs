using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Product : UserControl, IProduct
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Product()
    {
        InitializeComponent();
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeProducts") TreeNavSelect?.Invoke(s, e);
        };
    }

    private void OnProductLoad(object sender, EventArgs e)
    {
        SideNav.FocusNode("NodeProducts");
    }

}
