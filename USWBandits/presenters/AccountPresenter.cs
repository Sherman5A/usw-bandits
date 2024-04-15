using System.Diagnostics;
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
        View.AddAccountClicked += OnAddAccountClicked;
        Model = new AccountModel(modelData);
        InitView();
    }

    private void InitView()
    {
        View.SetAccountID(Model.GetAccountNumber() + 1);
        View.SetCustomerOptions(Model.GetCustomers());
        View.SetProductOptions(Model.GetProducts());
    }

    private void OnAddAccountClicked(object sender, EventArgs e)
    {
        int accID = Model.GetAccountNumber() + 1;
        int customerID = View.GetCustomerID();
        int productID = View.GetProductID();
        decimal balance = View.Balance;
        decimal accrued = View.Accrued;
        Debug.WriteLine(accID);
        Debug.WriteLine(customerID);
        Debug.WriteLine(productID);
        Debug.WriteLine(balance);
        Debug.WriteLine(accrued);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
