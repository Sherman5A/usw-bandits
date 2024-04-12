using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Home : UserControl, IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public IPresenter Presenter { get; set; }

    public Home()
    {
        InitializeComponent();
        sideNav.TreeNavSelect += (s, e) => TreeNavSelect?.Invoke(s, e);
    }
}
