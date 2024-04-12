namespace USWBandits.views;

public interface IStart : IView
{
    public event EventHandler<ConnectDatabaseEventArgs> ConnectDatabase;
}
