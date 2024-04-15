using USWBandits.views;
using USWBandits.models;

namespace USWBandits.presenters;

internal class CustomersPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ICustomers View { get; set; }
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public CustomersPresenter(Control parentControl, ICustomers view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        Model = new GenericModel(modelData);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
