namespace USWBandits;

public interface INav
{
    UserControl CurrentView { get; }

    void GoTo(UserControl view);
}
