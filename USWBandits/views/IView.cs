using USWBandits.presenters;

namespace USWBandits.views;

public interface IView
{
    public IPresenter? Presenter { get; set; }
}
