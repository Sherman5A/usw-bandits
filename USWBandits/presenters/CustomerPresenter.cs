using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class CustomerPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ICustomer View { get; set; }
    public CustomerModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;


    public CustomerPresenter(Control parentControl, ICustomer view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        Model = new CustomerModel(modelData);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
