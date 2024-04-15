using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class AccountsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IAccounts View { get; set; }
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public AccountsPresenter(Control parentControl, IAccounts view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        Model = new GenericModel(modelData);
        View.ButtonAddCustomer += (s, e) => ChangePresenter(
            new AccountPresenter(ParentControl, new Account(), ModelData)
        );
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
