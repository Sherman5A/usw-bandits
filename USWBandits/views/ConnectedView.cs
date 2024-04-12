using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class ConnectedView : UserControl, IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public IPresenter Presenter { get; set; }

    public ConnectedView()
    {
        InitializeComponent();
        sideNav.TreeNavSelect += (s, e) => TreeNavSelect?.Invoke(s, e);
    }
}
