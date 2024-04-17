namespace USWBandits.views;

/// <summary>
/// Interface between Start and StartPresenter
/// </summary>
public interface IStart : IView
{
    public event EventHandler<ConnectDatabaseEventArgs> ConnectDatabase;
}
