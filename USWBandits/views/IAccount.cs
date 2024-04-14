using USWBandits.components;

namespace USWBandits.views;

public interface IAccount : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
}
