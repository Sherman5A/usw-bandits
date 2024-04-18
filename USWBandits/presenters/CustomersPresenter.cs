using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class CustomersPresenter : SideNavPresenters, IPresenter
{
    public CustomersPresenter(Control parentControl, ICustomers view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddCustClick += (s, e) =>
            ChangePresenter(new CustomerPresenter(ParentControl, new Customer(), Model.ModelData)
            );
        Model = new GenericModel(modelData);
        View.AddNavItems(Model.GetCustomers());
    }

    public ICustomers View { get; set; }
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override Control ParentControl { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
