using System.Diagnostics;
using USWBandits.views;

namespace USWBandits.presenters;

public class AccountsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IAccounts View { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public AccountsPresenter(Control parentControl, IAccounts view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
