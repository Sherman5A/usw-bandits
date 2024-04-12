using USWBandits.views;

namespace USWBandits.presenters;

public class HomePresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public IHome View { get; set; }
    public UserControl ViewControl => View as UserControl;


    public HomePresenter(Control parentControl, IHome view)
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
