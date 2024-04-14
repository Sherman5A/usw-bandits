using USWBandits.components;

namespace USWBandits.views;

public interface IProducts : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
}
