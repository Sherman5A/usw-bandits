using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Customer : UserControl, ICustomer
{
    public Customer()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler? ButtonDeleteCustomerClicked;
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustomerClicked;

    public void EditMode()
    {
        NumericAllowance.Maximum = decimal.MaxValue;
        ButtonAddCustomer.Text = "Edit transaction";
        ButtonAddCustomer.Click += (s, e) => ButtonEditCustomerClicked?.Invoke(s, e);
        ButtonDelete.Enabled = true;
        ButtonDelete.Click += (s, e) => ButtonDeleteCustomerClicked?.Invoke(s, e);
    }

    public decimal Allowance
    {
        get => NumericAllowance.Value;
        set => NumericAllowance.Value = value;
    }

    public int CustomerId
    {
        get => Convert.ToInt32(LabelCustomerId.Text);
        set => LabelCustomerId.Text = value.ToString();
    }

    public string Title
    {
        get => TextTitle.Text;
        set => TextTitle.Text = value;
    }

    public string FirstName
    {
        get => TextFirstName.Text;
        set => TextFirstName.Text = value;
    }

    public string LastName
    {
        get => TextLastName.Text;
        set => TextLastName.Text = value;
    }

    public DateOnly CustomerDob
    {
        get => DateOnly.FromDateTime(DatePickDOB.Value);
        set => DatePickDOB.Value = value.ToDateTime(TimeOnly.FromDateTime(DateTime.Now));
    }

    public string NiNumber
    {
        get => MaskedNI.Text;
        set => MaskedNI.Text = value;
    }

    public string Email
    {
        get => MaskedEmail.Text;
        set => MaskedEmail.Text = value;
    }

    public string Password
    {
        get => TextPassword.Text;
        set => TextPassword.Text = value;
    }

    public event EventHandler? ButtonEditCustomerClicked;

    public void ShowResult(int result)
    {
        MessageBox.Show($"Database added {result} rows");
    }

    public void AddNavItems(List<BankCustomer> customers)
    {
        SideNav.AddItem(customers);
    }

    public void ShowError(string message)
    {
        MessageBox.Show(message);
    }

    private void OnCustomerLoad(object sender, EventArgs eventArgs)
    {
        NumericAllowance.Maximum = decimal.MaxValue;
        ButtonAddCustomer.Click += (s, e) => ButtonAddCustomerClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeCustomers") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeCustomers");
    }
}
