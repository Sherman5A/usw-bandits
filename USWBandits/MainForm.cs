namespace USWBandits;

public partial class MainForm : Form
{
    public Control Control { get; set; }
    public MainForm()
    {
        InitializeComponent();
    }

    public void ChangeView(UserControl view)
    {
        Host.Controls.Add(new HomeView(null));
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        Control.GoToDefault();
    }

    private void HostControlAdded(object sender, ControlEventArgs e)
    {
        e.Control.Dock = DockStyle.Fill;
    }
}