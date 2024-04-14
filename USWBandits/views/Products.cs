using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Products : UserControl, IProducts
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Products()
    {
        InitializeComponent();
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeProducts") TreeNavSelect?.Invoke(s, e);
        };
    }

    private void OnProductsLoad(object sender, EventArgs e)
    {
        SideNav.FocusNode("NodeProducts");
    }
}
