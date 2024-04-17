namespace USWBandits.presenters;

/// <summary>
/// Presenter is a go-between for the model and view. It handles events,
/// passing data to the view, and grabbing data from the model
/// 
/// Contract defining what every presenter must implement
/// </summary>
public interface IPresenter
{
    /// <summary>
    /// Master control
    /// </summary>
    public Control ParentControl { get; set; }

    /// <summary>
    /// The view cast as a UserControl
    /// </summary>
    public UserControl ViewControl { get; }

    /// <summary>
    /// Swap to a different presenter that implements a different view
    /// </summary>
    /// <param name="presenter">Presenter to swap to</param>
    void ChangePresenter(IPresenter presenter);
}
