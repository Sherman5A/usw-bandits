namespace USWBandits
{
    public partial class HomeView : UserControl
    {
        private Control Control { get; set; }

        public HomeView(Control control)
        {
            Control = control;
            InitializeComponent();
        }
    }
}
