using USWBandits.views;

namespace USWBandits.presenters;

public class ConnectedHomePresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public ConnectedHome View { get; set; }
    public UserControl ViewControl => (UserControl)View;


    public ConnectedHomePresenter(Control parentControl, ConnectedHome view)
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
