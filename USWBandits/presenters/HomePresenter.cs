using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class HomePresenter : SideNavPresenters, IPresenter
{
    public HomePresenter(Control parentControl, IHome view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        Model = new HomeModel(modelData);
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonCustomersClick += (s, e) => ChangePresenter(new
            CustomersPresenter(ParentControl, new Customers(), Model.ModelData)
        );
        View.ButtonProductsClick += (s, e) => ChangePresenter(
            new ProductsPresenter(ParentControl, new Products(), Model.ModelData)
        );
        View.ButtonAccountsClick += (s, e) => ChangePresenter(
            new AccountsPresenter(ParentControl, new Accounts(), Model.ModelData)
        );
        View.ButtonTransactionsClick += (s, e) => ChangePresenter(
            new TransactionsPresenter(ParentControl, new Transactions(), Model.ModelData)
        );
    }

    public IHome View { get; set; }
    public HomeModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override Control ParentControl { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
