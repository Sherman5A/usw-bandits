using USWBandits.views;

namespace USWBandits.presenters;

public class StartPresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public Start View { get; set; }
    public UserControl ViewControl => View;


    public StartPresenter(Control parentControl, Start view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.ConnectDatabase += HandleDatabaseConnect;
    }

    private void HandleDatabaseConnect(object sender, ConnectDatabaseEventArgs e)
    {
        ParentControl.GoTo(new HomePresenter(ParentControl, new Home()));
    }

    public void ChangePresenter(IPresenter presenter)
    {
        throw new NotImplementedException();
    }
}
