using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

public interface ITransactionsByCustomer : IView
{
    int CustomerId { get; }
    List<(int customer, string firstName, string lastName)> ComboCustomers { set; }
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
    public event EventHandler ButtonStartQuery;
    void ShowTransactions(List<BankTransaction> transactions);
}
