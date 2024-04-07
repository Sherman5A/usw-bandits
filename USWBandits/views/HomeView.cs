using USWBandits.presenters;

namespace USWBandits.views;

public partial class HomeView : UserControl, IView
{
    public IPresenter Presenter { get; set; }
    public event EventHandler<ConnectDatabaseEventArgs> ConnectDatabase;

    public HomeView()
    {
        InitializeComponent();
    }

    private void OnBtnConnectClick(object sender, EventArgs e)
    {
        ConnectDatabaseEventArgs args = new ConnectDatabaseEventArgs
        {
            DatabasePath = "jeff"
        };
        ConnectDatabase(this, args);
    }
}

public class ConnectDatabaseEventArgs: EventArgs {
    public string DatabasePath { get; set; }
}