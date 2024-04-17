using USWBandits.presenters;

namespace USWBandits.views;

/// <summary>
/// Views will have little logic in them. They are always linked to
/// a presenter that handles their events and data retrieval.
/// 
/// Standard class for all single pages of the application
/// </summary>
public interface IView
{
    public IPresenter? Presenter { get; set; }
}
