using USWBandits.components;

namespace USWBandits.views;

/// <summary>
/// Interface between Stats and StatsPresenter
/// </summary>
internal interface IStats : IView
{
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
}
