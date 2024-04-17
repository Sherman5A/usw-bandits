using System.Diagnostics;
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
        View.ButtonAddTransactionClicked += OnAddProductClicked;
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
            Debug.WriteLine(Transaction.Action.ToString());
            View.Action = Transaction.Action;
            View.TransactionEvent = Transaction.Event;
            View.ButtonEditTransactionClicked += OnEditTransaction;
            View.ButtonDeleteTransactionClicked += OnDeleteTransaction;
        }
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
        throw new NotImplementedException();
    }


    private void InitView()
    {
        View.AddNavItems(Model.GetTransactions());
        View.TransactionId = (Model.GetCurrentTransactionId() + 1);
        View.SetAccountOptions(Model.GetAccounts());
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void OnAddProductClicked(object? sender, EventArgs eventArgs)
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
        BankTransaction product = new(transactionId, accountID, transactionAction, amount, tranEvent);
        int result = Model.AddTransaction(product);
        View.ShowResult(result);
        if (result == 1)
        {
            View.TransactionId = (Model.GetCurrentTransactionId() + 1);
        }
    }
}
