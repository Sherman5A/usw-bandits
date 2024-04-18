using USWBandits.models;
using USWBandits.views;


namespace USWBandits.presenters;

public class TransactionsByCustomerPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ITransactionsByCustomer View { get; set; }
    public TransactionsByCustomerModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public TransactionsByCustomerPresenter(Control parentControl, ITransactionsByCustomer view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonStartQuery += OnStartQuery;
        Model = new TransactionsByCustomerModel(modelData);
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
