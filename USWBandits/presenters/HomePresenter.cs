using USWBandits.views;

namespace USWBandits.presenters;

public class HomePresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IHome View { get; set; }
    public override UserControl ViewControl => View as UserControl;


    public HomePresenter(Control parentControl, IHome view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        // View.ButtonCustomersClick += (s, e) => ChangePresenter(new ProductsPresenter(ParentControl, new Products()));
        View.ButtonProductsClick += (s, e) => ChangePresenter(
            new ProductsPresenter(ParentControl, new Products())
        );
        View.ButtonAccountsClick += (s, e) => ChangePresenter(
            new AccountsPresenter(ParentControl, new Accounts())
        );
        // View.ButtonTransactionClick += (s, e) => ChangePresenter(new ProductsPresenter(ParentControl, new Products()));
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
