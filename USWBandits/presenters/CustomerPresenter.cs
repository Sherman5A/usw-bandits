using USWBandits.logic;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class CustomerPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ICustomer View { get; set; }
    public CustomerModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;


    public CustomerPresenter(Control parentControl, ICustomer view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddCustomersClicked += OnAddCustomerClicked;
        Model = new CustomerModel(modelData);
        InitView();
    }

    private void InitView()
    {
        View.SetCustomerId(Model.GetCurrentCustomerId() + 1);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void OnAddCustomerClicked(object? sender, EventArgs eventArgs)
    {
        int customerId = Model.GetCurrentCustomerId() + 1;
        string title = View.GetCustomerTitle();
        string firstName = View.GetFirstName();
        string lastName = View.GetLastName();
        DateOnly customerDOB = View.GetDateBirth();
        string niNumber = View.GetNiNumber();
        string email = View.GetEmail();
        string password = View.GetPassword();
        decimal allowance = View.Allowance;
        BankCustomer customer = new(customerId, title, firstName, lastName, email, password, niNumber, allowance,
            customerDOB);
        int result = Model.AddCustomer(customer);
        View.ShowResult(result);
        if (result == 1)
        {
            View.SetCustomerId(Model.GetCurrentCustomerId() + 1);
        }
    }
}
