using USWBandits.presenters;

namespace USWBandits.views;

public partial class Start : UserControl, IStart
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<ConnectDatabaseEventArgs> ConnectDatabase;

    public Start()
    {
        InitializeComponent();
    }

    private void OnBtnConnectClick(object sender, EventArgs e)
    {
        ConnectDatabaseEventArgs args = new ConnectDatabaseEventArgs
        {
            DatabasePath = "bandits.db"
        };
        ConnectDatabase(this, args);
    }
}

public class ConnectDatabaseEventArgs : EventArgs
{
    public string DatabasePath { get; set; }
}
