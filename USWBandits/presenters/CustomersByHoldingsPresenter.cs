using USWBandits.models;
using USWBandits.views;


namespace USWBandits.presenters;

internal class CustomersByHoldingsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ICustomersByHoldings View { get; set; }
    public TotalDepWithModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public CustomersByHoldingsPresenter(Control parentControl, ICustomersByHoldings view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonStartQuery += OnStartQuery;
        Model = new TotalDepWithModel(modelData);
    }

    private void OnStartQuery(object? sender, EventArgs e)
    {
        // Do query
        throw new NotImplementedException();
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
