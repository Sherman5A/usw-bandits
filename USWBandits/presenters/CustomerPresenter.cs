using USWBandits.logic;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

/// <summary>
/// Interfaces between CustomerView and CustomerModel
/// </summary>
/// <param name="parentControl">Master control for switching views</param>
/// <param name="view">View</param>
/// <param name="modelData">Persistent data</param>
public class CustomerPresenter : SideNavPresenters, IPresenter
{

    public CustomerPresenter(Control parentControl, ICustomer view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddCustomerClicked += OnAddCustomerClicked;
        Model = new CustomerModel(modelData);
        InitView();
    }

    /// <summary>
    /// Overload for editing Customers
    /// </summary>
    public CustomerPresenter(Control parentControl, Customer view, ModelData modelData, int tableKey) : this(
        parentControl, view, modelData)
    {
        TableKey = tableKey;
        var customer = Model.GetCustomerByKey(TableKey);
        if (customer is null)
        {
            View.ShowError("Transaction does not exist");
        }
        else
        {
            Customer = customer;
            View.EditMode();
            View.CustomerId = Customer.CustomerId;
            View.Title = Customer.Title;
            View.FirstName = Customer.FirstName;
            View.LastName = Customer.LastName;
            View.CustomerDob = Customer.CustomerDob;
            View.NiNumber = Customer.NiNumber;
            View.Email = Customer.Email;
            View.Password = Customer.Password;
            View.Allowance = Customer.Allowance;
            // Remove previous event binding
            View.ButtonAddCustomerClicked -= OnAddCustomerClicked;
            // Add new event binding
            View.ButtonEditCustomerClicked += OnEditCustomer;
            View.ButtonDeleteCustomerClicked += OnDeleteCustomer;
        }
    }

    public ICustomer View { get; set; }
    public CustomerModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public int TableKey { get; set; }
    public BankCustomer Customer { get; set; }
    public override Control ParentControl { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void OnDeleteCustomer(object? sender, EventArgs e)
    {
        var result = Model.DeleteCustomerByKey(Customer.CustomerId);
        if (result != 1) return;
        View.ShowResult(result);
        ChangePresenter(new CustomersPresenter(ParentControl, new Customers(), ModelData));
    }

    private void OnEditCustomer(object? sender, EventArgs e)
    {
        var transaction = CreateCustomer(true);
        var result = Model.EditCustomer(transaction);
        if (result != 1) return;
        View.ShowResult(result);
        ChangePresenter(new CustomersPresenter(ParentControl, new Customers(), ModelData));
    }


    private void InitView()
    {
        View.AddNavItems(Model.GetCustomers());
        View.CustomerId = Model.GetCurrentCustomerId() + 1;
    }


    private void OnAddCustomerClicked(object? sender, EventArgs eventArgs)
    {
        var customer = CreateCustomer(false);
        var result = Model.AddCustomer(customer);
        View.ShowResult(result);
        if (result == 1) View.CustomerId = Model.GetCurrentCustomerId() + 1;
    }

    private BankCustomer CreateCustomer(bool editMode)
    {
        var customerId = editMode ? TableKey : Model.GetCurrentCustomerId() + 1;
        var title = View.Title;
        var firstName = View.FirstName;
        var lastName = View.LastName;
        var customerDob = View.CustomerDob;
        var niNumber = View.NiNumber;
        var email = View.Email;
        var password = View.Password;
        var allowance = View.Allowance;
        BankCustomer customer = new(customerId, title, firstName, lastName, email, password, niNumber, allowance,
            customerDob);
        return customer;
    }
}
