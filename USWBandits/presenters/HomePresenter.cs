using USWBandits.views;

namespace USWBandits.presenters;

public class HomePresenter : Presenter
{
    public HomePresenter(Control parentControl, Home view) : base(parentControl, view)
    {
        view.ConnectDatabase += HandleDatabaseConnect;
    }


    private void HandleDatabaseConnect(object sender, ConnectDatabaseEventArgs e)
    {
        ParentControl.GoTo(new ConnectedHomePresenter(ParentControl, new ConnectedHome()));
    }
}
