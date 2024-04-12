using System.Diagnostics;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class NavBar : UserControl, IView
{
    public IPresenter Presenter { get; set; }

    public NavBar()
    {
        InitializeComponent();
    }

    private void TreeNavAfterSelect(object sender, TreeViewEventArgs e)
    {
        Debug.WriteLine(e.Node);
    }
}