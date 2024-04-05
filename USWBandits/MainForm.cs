using System.Diagnostics;

namespace USWBandits
{
    public partial class MainForm : Form
    {
        public Control Control { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        public void ChangeView(UserControl view)
        {
            Debug.WriteLine("running");
            host.Controls.Add(new HomeView(null));
            Debug.WriteLine(host.Controls.ToString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Control.GoToDefault();
        }
    }
}
