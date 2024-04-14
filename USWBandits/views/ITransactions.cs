using USWBandits.components;

namespace USWBandits.views;

public interface ITransactions : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
}
