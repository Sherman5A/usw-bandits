using USWBandits.logic;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class ProductPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IProduct View { get; set; }
    public ProductModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public ProductPresenter(Control parentControl, IProduct view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddProductClicked += OnAddProductClicked;

        Model = new ProductModel(modelData);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void OnAddProductClicked(object? sender, EventArgs eventArgs)
    {
        int productId = Model.GetCurrentProductId() + 1;
        string accountName = View.GetAccountName();
        ProductOpenStatus? getResult = View.GetStatus();
        if (getResult is null)
        {
            View.ShowError("Invalid product status");
            return;
        }
        ProductOpenStatus productStatus = (ProductOpenStatus)getResult;
        int productInterest = View.Interest;
        BankProduct product = new(productId, accountName, productStatus, productInterest);
        int result = Model.AddProduct(product);
        View.ShowResult(result);
    }
}
