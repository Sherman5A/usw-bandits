namespace USWBandits;

/// <summary>
/// Controller class. Interfaces between the model and views
/// </summary>
public class Control : INav
{
    public MainForm Form { get; }
    public UserControl CurrentView { get; private set; }

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
    public void GoTo(UserControl view)
    {
        CurrentView = view;
        Form.ChangeView(CurrentView);
    }

    /// <summary>
    /// Swap to the default view of the program
    /// </summary>
    public void GoToDefault()
    {
        GoTo(new HomeView(this));
    }

    /// <summary>
    /// Start the form's application loop
    /// </summary>
    public void Start()
    {
        Application.Run(Form);
    }
}
