using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

internal interface ITotalDepWith : IView
{
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
    public event EventHandler? ButtonStartQuery;
    DateTime LowerDate { get; set; }
    DateTime UpperDate { get; set; }
    TransactionAction? TransactionAction { get; set; }
    void AddTransactions(List<BankAccount> accounts);
}
