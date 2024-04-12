using USWBandits.views;

namespace USWBandits.presenters;

public class ProductPresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public IProduct View { get; set; }

    public UserControl ViewControl => View as UserControl;

    public ProductPresenter(Control parentControl, IProduct view)
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
