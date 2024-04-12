namespace USWBandits.views;

public interface IHome : IView
{
    public event EventHandler<ConnectDatabaseEventArgs> ConnectDatabase;
}
