using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

internal class TransactionsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ITransactions View { get; set; }
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public TransactionsPresenter(Control parentControl, ITransactions view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonAddTransactionClick += (s, e) => ChangePresenter(new TransactionPresenter(ParentControl, new Transaction(), Model.ModelData));
        Model = new GenericModel(modelData);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
