using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Stats : UserControl, IStats
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonCalculateInterestClicked;
    public event EventHandler? ButtonCustomerByHoldingsClicked;
    public event EventHandler? ButtonTranscationsByDateClicked;
    public event EventHandler? ButtonTransactionByCustomerClicked;


    public Stats()
    {
        InitializeComponent();
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeStats") TreeNavSelect?.Invoke(s, e);
        };
    }

    private void OnProductLoad(object sender, EventArgs eventArgs)
    {
        SideNav.FocusNode("NodeStats");
        ButtonCalcInterest.Click += (s, e) => ButtonCalculateInterestClicked?.Invoke(s, e);
        ButtonCustomerByHoldings.Click += (s, e) => ButtonCustomerByHoldingsClicked?.Invoke(s, e);
        ButtonTotalTransaction.Click += (s, e) => ButtonTranscationsByDateClicked?.Invoke(s, e);
        ButtonTransactionByCustomer.Click += (s, e) => ButtonTransactionByCustomerClicked?.Invoke(s, e);
    }

}
