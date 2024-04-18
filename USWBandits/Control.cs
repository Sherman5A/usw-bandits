using USWBandits.presenters;
using USWBandits.views;

namespace USWBandits;

/// <summary>
///     Controller class. Interfaces between the main form and presenters, allowing
///     for swapping views
/// </summary>
public class Control : INav
{
    /// <summary>
    ///     Starts controller class, injects itself into form
    /// </summary>
    /// <param name="form">The form that the controller will handle</param>
    public Control(MainForm form)
    {
        Form = form;
        Form.Control = this;
    }

    public MainForm Form { get; }
    public IPresenter CurrentPresenter { get; private set; }

    /// <summary>
    ///     Swap to a given presenter that has is coupled to a view
    /// </summary>
    /// <param name="view">The presenter to swap to</param>
    public void GoTo(IPresenter presenter)
    {
        CurrentPresenter = presenter;
        Form.ChangeView(CurrentPresenter.ViewControl);
    }

    /// <summary>
    ///     Swap to the default starting view of the program
    /// </summary>
    public void GoToDefault()
    {
        GoTo(new StartPresenter(this, new Start()));
    }

    /// <summary>
    ///     Start the form's application loop
    /// </summary>
    public void Start()
    {
        Application.Run(Form);
    }
}
