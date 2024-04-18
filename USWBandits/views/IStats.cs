using USWBandits.components;

namespace USWBandits.views;

/// <summary>
/// Interface between Stats and StatsPresenter
/// </summary>
public interface IStats : IView
{
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
    public event EventHandler? ButtonCalculateInterestClicked;
    public event EventHandler? ButtonCustomerByHoldingsClicked;
    public event EventHandler? ButtonTranscationsByDateClicked;
    public event EventHandler? ButtonTransactionByCustomerClicked;
}
