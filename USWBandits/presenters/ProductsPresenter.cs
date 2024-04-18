using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class ProductsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IProducts View { get; set; }
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;


    public ProductsPresenter(Control parentControl, IProducts view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddProductClick += (s, e) =>
            ChangePresenter(new ProductPresenter(ParentControl, new Product(), Model.ModelData));
        Model = new GenericModel(modelData);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
    