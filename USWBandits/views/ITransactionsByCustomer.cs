using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

public interface ITransactionsByCustomer : IView
{
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
    public event EventHandler ButtonStartQuery;
    int CustomerId { get; }
    List<(int customer, string firstName, string lastName)> ComboCustomers { set; }
    void ShowTransactions(List<BankTransaction> transactions);
}