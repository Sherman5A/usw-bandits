using System.Diagnostics;
using USWBandits.logic;
using USWBandits.models;
using USWBandits.views;


namespace USWBandits.presenters;

internal class AccountPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IAccount View { get; set; }
    public AccountModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;
    public int TableKey { get; set; }
    public BankAccount Account { get; set; }

    public AccountPresenter(Control parentControl, IAccount view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddAccountClicked += OnAddAccountClicked;
        Model = new AccountModel(modelData);
        InitView();
    }

    public AccountPresenter(Control parentControl, Account view, ModelData modelData, int tableKey) : this(
        parentControl, view, modelData)
    {
        TableKey = tableKey;
        BankAccount? account = Model.GetAccountByKey(TableKey);
        if (account is null)
        {
            View.ShowError("Transaction does not exist");
        }
        else
        {
            Account = account;
            View.EditMode();
            Debug.WriteLine(Account.CustomerID);
            Debug.WriteLine(Account.ProductID);
            View.AccountId = Account.AccountID;
            View.CustomerId = Account.CustomerID;
            View.ProductId = Account.ProductID;
            View.Balance = Account.Balance;
            View.Accrued = Account.Accrued;
            // Remove previous event binding
            View.ButtonAddAccountClicked -= OnAddAccountClicked;
            // Add new event binding
            View.ButtonEditAccountClicked += OnEditTransaction;
            View.ButtonDeleteAccountClicked += OnDeleteTransaction;
        }
    }


    private void InitView()
    {
        View.AddNavItems(Model.GetAccounts());
        View.AccountId = (Model.GetAccountNumber() + 1);
        View.SetCustomerOptions(Model.GetCustomers());
        View.SetProductOptions(Model.GetProducts());
    }

    private void OnAddAccountClicked(object? sender, EventArgs e)
    {
        var account = CreateAccount(false);
        int result = Model.AddAccount(account);
        View.ShowResult(result);
        if (result == 1)
        {
            View.AccountId = Model.GetAccountNumber() + 1;
        }
    }

    private void OnDeleteTransaction(object? sender, EventArgs e)
    {
        int result = Model.DeleteAccountByKey(Account.AccountID);
        if (result != 1) return;
        View.ShowResult(result);
        ChangePresenter(new AccountsPresenter(ParentControl, new Accounts(), ModelData));
    }

    private void OnEditTransaction(object? sender, EventArgs e)
    {
        var account = CreateAccount(true);
        int result = Model.EditAccount(account);
        if (result != 1) return;
        View.ShowResult(result);
        ChangePresenter(new TransactionsPresenter(ParentControl, new Transactions(), ModelData));
    }

    private BankAccount CreateAccount(bool editMode)
    {
        int accID = editMode ? TableKey : Model.GetAccountNumber() + 1;
        int customerID = View.CustomerId;
        int productID = View.ProductId;
        decimal balance = View.Balance;
        decimal accrued = View.Accrued;
        BankAccount account = new(accID, customerID, productID, balance, accrued);
        return account;
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
