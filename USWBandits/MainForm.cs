namespace USWBandits
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var homeView = new HomeView();
            ChangeView(homeView);
        }

        public void ChangeView(UserControl view)
        {
            host.Controls.Add(view);
        }
    }
}
