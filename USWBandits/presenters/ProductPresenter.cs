using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class ProductPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IProduct View { get; set; }
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public ProductPresenter(Control parentControl, IProduct view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
