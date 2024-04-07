using USWBandits.views;

namespace USWBandits.presenters;

public interface IPresenter
{
    public Control ParentControl { get; set; }
    public IView View { get; set; }
}
