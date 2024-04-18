using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

internal class StatsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IStats View { get; set; }
    public override UserControl ViewControl => View as UserControl;
    public StatsModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;

    public StatsPresenter(Control parentControl, IStats view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonCalculateInterestClicked += (s, e) => OnCalculateInterest();
        View.ButtonCustomerByHoldingsClicked += (s, e) =>
            ChangePresenter(new CustomersByHoldingsPresenter(ParentControl, new CustomersByHoldings(), ModelData));
        View.ButtonTransactionsByDateClicked += (s, e) => ChangePresenter(
            new TotalDepWithPresenter(ParentControl, new TotalDepWith(), ModelData));
        View.ButtonTransactionByCustomerClicked += (s, e) =>
            ChangePresenter(
                new TransactionsByCustomerPresenter(ParentControl, new TransactionsByCustomer(), ModelData));
        Model = new StatsModel(modelData);
    }

    private void OnCalculateInterest()
    {
        int result = Model.CalculateInterest();
        View.ShowMessage(result);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
