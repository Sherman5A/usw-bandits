using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Product : UserControl, IProduct
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddProductClicked;
    public event EventHandler? ButtonEditProductClicked;
    public event EventHandler? ButtonDeleteProductClicked;

    public Product()
    {
        InitializeComponent();
    }

    public void AddNavItems(List<BankProduct> products) => SideNav.AddItem(products);

    public void EditMode()
    {
        ButtonAddProduct.Text = "Edit product";
        ButtonAddProduct.Click += (s, e) => ButtonEditProductClicked?.Invoke(s, e);
        ButtonDelete.Enabled = true;
        ButtonDelete.Click += (s, e) => ButtonDeleteProductClicked?.Invoke(s, e);
    }

    private void OnProductLoad(object sender, EventArgs eventArgs)
    {
        ButtonAddProduct.Click += (s, e) => ButtonAddProductClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeProducts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeProducts");
    }

    public ProductOpenStatus? GetStatus()
    {
        if (Enum.TryParse<ProductOpenStatus>(ComboStatus.Text, out var returnValue))
        {
            return Enum.IsDefined(typeof(ProductOpenStatus), returnValue) ? returnValue : null;
        }

        return null;
    }

    public decimal Interest
    {
        get => Convert.ToDecimal(NumericRate.Value);
        set => NumericRate.Value = value;
    }

    public int ProductId
    {
        get => Convert.ToInt32(LabelId.Text);
        set => LabelId.Text = value.ToString();
    }

    public string AccountName
    {
        get => TextAccName.Text;
        set => TextAccName.Text = value;
    }

    public ProductOpenStatus? ProductStatus
    {
        get
        {
            if (Enum.TryParse<ProductOpenStatus>(ComboStatus.Text, out var returnValue))
            {
                return Enum.IsDefined(typeof(ProductOpenStatus), returnValue) ? returnValue : null;
            }

            return null;
        }
        set => ComboStatus.SelectedItem = value.ToString();
    }

    public void ShowError(string message)
    {
        MessageBox.Show($"Error: {message}");
    }

    public void ShowResult(int result)
    {
        MessageBox.Show($"Database added {result} rows");
    }
}
