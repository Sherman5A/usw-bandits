using USWBandits.presenters;
using USWBandits.views;

namespace USWBandits;

/// <summary>
/// Controller class. Interfaces between the model and views
/// </summary>
public class Control : INav
{
    public MainForm Form { get; }
    public IPresenter CurrentPresenter { get; private set; }

    /// <summary>
    /// Starts controller class, injects into form
    /// </summary>
    /// <param name="form">The form that the controller will handle</param>
    public Control(MainForm form)
    {
        Form = form;
        Form.Control = this;
    }

    /// <summary>
    /// Swap to a given view
    /// </summary>
    /// <param name="view">The view to swap to</param>
    public void GoTo(IPresenter presenter)
    {
        CurrentPresenter = presenter;
        Form.ChangeView((UserControl)CurrentPresenter.View);
    }

    /// <summary>
    /// Swap to the default view of the program
    /// </summary>
    public void GoToDefault()
    {
        GoTo(new HomePresenter(this, new HomeView()));
    }

    /// <summary>
    /// Start the form's application loop
    /// </summary>
    public void Start()
    {
        Application.Run(Form);
    }
}
