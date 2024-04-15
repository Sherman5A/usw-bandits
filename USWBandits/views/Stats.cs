using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Stats : UserControl, IStats
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Stats()
    {
        InitializeComponent();
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeStats") TreeNavSelect?.Invoke(s, e);
        };
    }

    private void OnProductLoad(object sender, EventArgs e)
    {
        SideNav.FocusNode("NodeStats");
    }

}
