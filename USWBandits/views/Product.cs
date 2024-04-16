using USWBandits.components;
using USWBandits.logic;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Product : UserControl, IProduct
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddProductClicked;

    public Product()
    {
        InitializeComponent();
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

    public string GetAccountName()
    {
        return TextAccName.Text;
    }

    public ProductOpenStatus? GetStatus()
    {
        if (Enum.TryParse<ProductOpenStatus>(ComboStatus.Text, out var returnValue))
        {
            return Enum.IsDefined(typeof(ProductOpenStatus), returnValue) ? returnValue : null;
        }

        return null;
    }

    public int Interest
    {
        get => Convert.ToInt32(NumericRate.Value);
        set => NumericRate.Value = value;
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
