using USWBandits.presenters;

namespace USWBandits.views;

public partial class ConnectedHome : UserControl, IView
{
    public IPresenter Presenter { get; set; }

    public ConnectedHome()
    {
        InitializeComponent();
    }

}