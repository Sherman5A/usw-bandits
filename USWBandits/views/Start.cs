using System.ComponentModel;
using USWBandits.presenters;

namespace USWBandits.views;

/// <summary>
/// Starting page for the program
/// </summary>
public partial class Start : UserControl, IStart
{
    public Start()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<ConnectDatabaseEventArgs> ConnectDatabase;
    private OpenFileDialog openFileDialog;


    private void OnBtnConnectClick(object sender, EventArgs e)
    {
        var args = new ConnectDatabaseEventArgs
        {
            DatabasePath = openFileDialog.SafeFileName
        };
        ConnectDatabase(this, args);
    }

    private void ButtonFolderClick(object sender, EventArgs e)
    {
        openFileDialog.ShowDialog();
    }

    private void StartLoad(object sender, EventArgs e)
    {
        openFileDialog = new OpenFileDialog();
        openFileDialog.FileOk += SetFilePath;
        openFileDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
    }

    private void SetFilePath(object? sender, CancelEventArgs e)
    {
        LabelDatabasePath.Text = openFileDialog.SafeFileName;
    }
}

public class ConnectDatabaseEventArgs : EventArgs
{
    public string DatabasePath { get; set; }
}
