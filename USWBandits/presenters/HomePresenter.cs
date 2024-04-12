using USWBandits.views;

namespace USWBandits.presenters;

public class HomePresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public Home View { get; set; }
    public UserControl ViewControl => (UserControl)View;


    public HomePresenter(Control parentControl, Home view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.ConnectDatabase += HandleDatabaseConnect;
    }

    private void HandleDatabaseConnect(object sender, ConnectDatabaseEventArgs e)
    {
        ParentControl.GoTo(new AccountPresenter(ParentControl, new Accounts()));
    }

    public void ChangePresenter(IPresenter presenter)
    {
        throw new NotImplementedException();
    }
}
