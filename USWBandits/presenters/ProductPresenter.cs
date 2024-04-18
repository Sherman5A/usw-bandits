using USWBandits.logic;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

/// <summary>
/// Interfaces between ProductView and ProductModel
/// </summary>
/// <param name="parentControl">Master control for switching views</param>
/// <param name="view">View</param>
/// <param name="modelData">Persistent data</param>
public class ProductPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IProduct View { get; set; }
    public ProductModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;
    public int TableKey { get; set; }
    public BankProduct Product { get; set; }


    public ProductPresenter(Control parentControl, IProduct view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddProductClicked += OnAddProductClicked;
        Model = new ProductModel(modelData);
        InitView();
    }

    /// <summary>
    /// Overload for editing Products
    /// </summary>
    public ProductPresenter(Control parentControl, Product view, ModelData modelData, int tableKey) : this(
        parentControl, view, modelData)
    {
        TableKey = tableKey;
        BankProduct? transaction = Model.GetProductByKey(TableKey);
        if (transaction is null)
        {
            View.ShowError("Transaction does not exist");
        }
        else
        {
            Product = transaction;
            View.EditMode();
            View.ProductId = Product.ProductID;
            View.AccountName = Product.AccountName;
            View.ProductStatus = Product.ProductStatus;
            View.Interest = Product.ProductInterest;
            // Remove previous event binding
            View.ButtonAddProductClicked -= OnAddProductClicked;
            // Add new event binding
            View.ButtonEditProductClicked += OnEditProduct;
            View.ButtonDeleteProductClicked += OnDeleteProduct;
        }
    }

    private void OnDeleteProduct(object? sender, EventArgs e)
    {
        int result = Model.DeleteProductByKey(Product.ProductID);
        if (result != 1) return;
        View.ShowResult(result);
        ChangePresenter(new ProductsPresenter(ParentControl, new Products(), ModelData));
    }

    private void OnEditProduct(object? sender, EventArgs e)
    {
        var product = CreateProduct(true);
        int result = Model.EditProduct(product);
        if (result != 1) return;
        View.ShowResult(result);
        ChangePresenter(new ProductsPresenter(ParentControl, new Products(), ModelData));
    }

    private BankProduct? CreateProduct(bool editMode)
    {
        int productId = editMode ? TableKey : Model.GetCurrentProductId() + 1;
        string accountName = View.AccountName;
        ProductOpenStatus? getResult = View.ProductStatus;
        if (getResult is null)
        {
            return null;
        }

        ProductOpenStatus productStatus = (ProductOpenStatus)getResult;
        decimal productInterest = View.Interest;
        return new BankProduct(productId, accountName, productStatus, productInterest);
    }


    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void InitView()
    {
        View.AddNavItems(Model.GetTransactions());
        View.ProductId = (Model.GetCurrentProductId() + 1);
    }

    private void OnAddProductClicked(object? sender, EventArgs eventArgs)
    {
        var product = CreateProduct(false);
        if (product is null)
        {
            View.ShowError("Invalid product status");
            return;
        }

        int result = Model.AddProduct(product);
        View.ShowResult(result);
        if (result == 1)
        {
            View.ProductId = (Model.GetCurrentProductId() + 1);
        }
    }
}
