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

    private void InitView()
    {
        View.SetAccountOptions(Model.GetAccounts());
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void OnAddProductClicked(object? sender, EventArgs eventArgs)
    {
        int transactionId = Model.GetCurrentTransactionId() + 1;
        int accountID = View.GetAccountId();
        TransactionAction action = View.GetAction();
        decimal amount = View.Amount;
        DateTime tranEvent = View.GetEvent();
        BankTransaction product = new(transactionId, accountID, action, amount, tranEvent);
        int result = Model.AddTransaction(product);
        View.ShowResult(result);
    }
}
