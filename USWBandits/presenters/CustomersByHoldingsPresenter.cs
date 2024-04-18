using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

internal class CustomersByHoldingsPresenter : SideNavPresenters, IPresenter
{
    public CustomersByHoldingsPresenter(Control parentControl, ICustomersByHoldings view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.StartQuery += OnStartQuery;
        Model = new CustomersByHoldingsModel(modelData);
    }

    public ICustomersByHoldings View { get; set; }
    public CustomersByHoldingsModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override Control ParentControl { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void OnStartQuery(object? sender, EventArgs e)
    {
        View.Customers = Model.GetMostValuableCustomers();
    }
}
