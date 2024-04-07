using USWBandits.presenters;

namespace USWBandits;

public interface INav
{
    IPresenter CurrentPresenter { get; }

    void GoTo(IPresenter presenter);
}
