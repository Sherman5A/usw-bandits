using USWBandits.components;

namespace USWBandits.views;

/// <summary>
/// Contract that must be enforced between Transactions and TransactionsPresenter
/// </summary>
public interface ITransactions : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddTransactionClick;
}
