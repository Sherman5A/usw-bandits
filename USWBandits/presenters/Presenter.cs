using USWBandits.views;

namespace USWBandits.presenters;

public abstract class Presenter : IPresenter
{
    public Control ParentControl { get; set; }
    public IView View { get; set; }

    protected Presenter(Control parentControl, IView view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
    }
}
