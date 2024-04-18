using USWBandits.logic;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class TransactionPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ITransaction View { get; set; }
    public TransactionModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;
    public int TableKey { get; set; }
    private BankTransaction Transaction { get; set; }

    public TransactionPresenter(Control parentControl, ITransaction view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddTransactionClicked += OnAddTransactionClicked;
        Model = new TransactionModel(modelData);
        InitView();
    }


    public TransactionPresenter(Control parentControl, Transaction view, ModelData modelData, int tableKey) : this(
        parentControl, view, modelData)
    {
        TableKey = tableKey;
        BankTransaction? transaction = Model.GetTransactionByKey(TableKey);
        if (transaction is null)
        {
            View.ShowError("Transaction does not exist");
        }
        else
        {
            Transaction = transaction;
            View.EditMode();
            View.TransactionId = Transaction.TransactionID;
            View.AccountId = Transaction.TranAccountID;
            View.Action = Transaction.Action;
            View.Amount = Transaction.Amount;
            View.TransactionEvent = Transaction.Event;
            // Remove previous event binding
            View.ButtonAddTransactionClicked -= OnAddTransactionClicked;
            // Add new event binding
            View.ButtonEditTransactionClicked += OnEditTransaction;
            View.ButtonDeleteTransactionClicked += OnDeleteTransaction;
        }
    }

    private void InitView()
    {
        View.AddNavItems(Model.GetTransactions());
        View.TransactionId = (Model.GetCurrentTransactionId() + 1);
        View.SetAccountOptions(Model.GetAccounts());
    }

    private void OnDeleteTransaction(object? sender, EventArgs eventArgs)
    {
        int result = Model.DeleteTransactionByKey(Transaction.TransactionID);
        if (result == 1)
        {
            View.ShowResult(result);
            ChangePresenter(new TransactionsPresenter(ParentControl, new Transactions(), ModelData));
        }
    }

    private void OnEditTransaction(object? sender, EventArgs eventArgs)
    {
        var transaction = CreateTransaction();
        int result = Model.EditTransaction(transaction);
        if (result == 1)
        {
            View.ShowResult(result);
            ChangePresenter(new TransactionsPresenter(ParentControl, new Transactions(), ModelData));
        }
    }


    private void OnAddTransactionClicked(object? sender, EventArgs eventArgs)
    {
        var transaction = CreateTransaction();
        int result = Model.AddTransaction(transaction);
        View.ShowResult(result);
        if (result == 1)
        {
            View.TransactionId = (Model.GetCurrentTransactionId() + 1);
        }
    }

    private BankTransaction CreateTransaction()
    {
        int transactionId = Model.GetCurrentTransactionId() + 1;
        int accountID = View.AccountId;
        TransactionAction? getResult = View.Action;
        if (getResult is null)
        {
            View.ShowError("Invalid transaction event");
        }

        TransactionAction transactionAction = (TransactionAction)getResult;

        decimal amount = View.Amount;
        DateTime tranEvent = View.TransactionEvent;
        BankTransaction transaction = new(transactionId, accountID, transactionAction, amount, tranEvent);
        return transaction;
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
