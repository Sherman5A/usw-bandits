using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

internal class StatsPresenter : SideNavPresenters, IPresenter
{
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

    public IStats View { get; set; }
    public StatsModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override Control ParentControl { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void OnCalculateInterest()
    {
        var result = Model.CalculateInterest();
        View.ShowMessage(result);
    }
}
