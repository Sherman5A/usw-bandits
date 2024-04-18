using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class TransactionsByCustomerPresenter : SideNavPresenters, IPresenter
{
    public TransactionsByCustomerPresenter(Control parentControl, ITransactionsByCustomer view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonStartQuery += OnStartQuery;
        Model = new TransactionsByCustomerModel(modelData);
        View.ComboCustomers = Model.GetCustomers();
    }

    public ITransactionsByCustomer View { get; set; }
    public TransactionsByCustomerModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override Control ParentControl { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }


    private void OnStartQuery(object? sender, EventArgs e)
    {
        View.ShowTransactions(Model.GetTransactionsByCustomer(View.CustomerId));
    }
}
