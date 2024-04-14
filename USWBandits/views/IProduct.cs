using USWBandits.components;

namespace USWBandits.views;

public interface IProduct : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
}
