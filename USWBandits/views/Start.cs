using USWBandits.presenters;

namespace USWBandits.views;

public partial class Start : UserControl, IStart
{
    public Start()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<ConnectDatabaseEventArgs> ConnectDatabase;

    private void OnBtnConnectClick(object sender, EventArgs e)
    {
        var args = new ConnectDatabaseEventArgs
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
