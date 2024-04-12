using USWBandits.views;

namespace USWBandits.presenters;

public class ProductsPresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public IProducts View { get; set; }
    public UserControl ViewControl => View as UserControl;

    public ProductsPresenter(Control parentControl, IProducts view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
    }

    public void ChangePresenter(IPresenter presenter)
    {
        throw new NotImplementedException();
    }
}
