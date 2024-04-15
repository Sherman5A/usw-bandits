using USWBandits.components;

namespace USWBandits.views;

internal interface IStats : IView
{
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
}
