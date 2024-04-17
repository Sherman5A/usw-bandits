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

    private void InitView()
    {
        View.SetAccountId(Model.GetAccountNumber() + 1);
        View.SetCustomerOptions(Model.GetCustomers());
        View.SetProductOptions(Model.GetProducts());
    }

    private void OnAddAccountClicked(object? sender, EventArgs e)
    {
        int accID = Model.GetAccountNumber() + 1;
        int customerID = View.GetCustomerID();
        int productID = View.GetProductID();
        decimal balance = View.Balance;
        decimal accrued = View.Accrued;
        BankAccount account = new(accID, customerID, productID, balance, accrued);
        int result = Model.AddAccount(account);
        View.ShowResult(result);
        if (result == 1)
        {
            View.SetAccountId(Model.GetAccountNumber() + 1);
        }
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
