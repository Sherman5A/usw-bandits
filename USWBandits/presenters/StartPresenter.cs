using USWBandits.views;

namespace USWBandits.presenters;

public class StartPresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public IStart View { get; set; }
    public UserControl ViewControl => View as UserControl;


    public StartPresenter(Control parentControl, IStart view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.ConnectDatabase += HandleDatabaseConnect;
    }

    private void HandleDatabaseConnect(object sender, ConnectDatabaseEventArgs e)
    {
        ChangePresenter(new HomePresenter(ParentControl, new Home()));
    }

    public void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
