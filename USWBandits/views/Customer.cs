using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Customer : UserControl, ICustomer
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddCustomersClicked;

    public Customer()
    {
        InitializeComponent();
    }

    private void OnCustomerLoad(object sender, EventArgs eventArgs)
    {
        NumericAllowance.Maximum = decimal.MaxValue;
        ButtonAddCustomer.Click += (s, e) => ButtonAddCustomersClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeCustomers") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeCustomers");
    }

    public decimal Allowance
    {
        get => NumericAllowance.Value;
        set => NumericAllowance.Value = value;
    }

    public DateOnly GetDateBirth()
    {
        // TODO: Create parser for this
        throw new NotImplementedException();
    }

    public string GetEmail()
    {
        return MaskedEmail.Text;
    }

    public string GetFirstName()
    {
        return TextFirstName.Text;
    }

    public string GetLastName()
    {
        return TextLastName.Text;
    }

    public string GetNiNumber()
    {
        return MaskedNI.Text;
    }

    public string GetPassword()
    {
        return TextPassword.Text;
    }

    public void ShowResult(int result)
    {
        MessageBox.Show($"Database added {result} rows");
    }

    public string GetCustomerTitle()
    {
        return TextTitle.Text;
    }
}
