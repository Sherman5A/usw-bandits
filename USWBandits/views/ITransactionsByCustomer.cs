using USWBandits.components;

namespace USWBandits.views;

public interface ITransactionsByCustomer : IView
{
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
    public event EventHandler ButtonStartQuery;
}