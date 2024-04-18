using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class AccountsPresenter : SideNavPresenters, IPresenter
{
    public AccountsPresenter(Control parentControl, IAccounts view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonNewAccountClick += (s, e) => ChangePresenter(
            new AccountPresenter(ParentControl, new Account(), ModelData)
        );
        Model = new GenericModel(modelData);
        View.AddNavItems(Model.GetAccounts());

    }

    public IAccounts View { get; set; }
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override Control ParentControl { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
