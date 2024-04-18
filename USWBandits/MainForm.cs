namespace USWBandits;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    /// <summary>
    ///     The controller that provides functions to swap between views
    /// </summary>
    public Control Control { get; set; }

    /// <summary>
    ///     Change the view to another one that implements IView interface
    /// </summary>
    /// <param name="view">UserControl that implements the IView interface</param>
    public void ChangeView(UserControl view)
    {
        Host.Controls.Clear();
        Host.Controls.Add(view);
    }

    private void MainFormLoad(object sender, EventArgs e)
    {
        Control.GoToDefault();
    }

    private void HostControlAdded(object sender, ControlEventArgs e)
    {
        e.Control.Dock = DockStyle.Fill;
    }

    public void SetConntectionStatus(bool status)
    {
        if (status)
        {
            LabelConnected.Text = "Connected";
        }
        else
        {
            LabelConnected.Text = "Disconnected";
        }
    }

    private void DisconnectClick(object sender, EventArgs e)
    {
        Control.Disconnect();
    }
}
