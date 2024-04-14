using USWBandits.components;

namespace USWBandits.views;

public interface ICustomer : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
}
