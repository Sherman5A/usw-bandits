namespace USWBandits;

public class Control : INav
{
    public MainForm Form { get; }
    public UserControl CurrentView { get; private set; }

    public Control(MainForm form)
    {
        Form = form;
        Form.Control = this;
    }

    public void GoTo(UserControl view)
    {
        CurrentView = view;
        Form.ChangeView(CurrentView);
    }

    public void GoToDefault()
    {
        GoTo(new HomeView(this));
    }

    public void Start()
    {
        Application.Run(Form);
    }
}
