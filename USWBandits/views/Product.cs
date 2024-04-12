using USWBandits.presenters;

namespace USWBandits.views;

public partial class Product : UserControl, IView
{
    public IPresenter Presenter { get; set; }

    public Product()
    {
        InitializeComponent();
    }
}
