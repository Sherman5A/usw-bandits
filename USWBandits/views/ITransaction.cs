using USWBandits.components;

namespace USWBandits.views;

public interface ITransaction : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
}
