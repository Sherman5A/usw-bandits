using System.Diagnostics;
using USWBandits.components;
using USWBandits.views;

namespace USWBandits.presenters;

public class AccountPresenter : IPresenter
{
    public Control ParentControl { get; set; }

    public IAccounts View { get; set; }
    public UserControl ViewControl => View as UserControl;

    public AccountPresenter(Control parentControl, IAccounts view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
    }

    private void OnTreeNavSelect(object? sender, TreeNavSelectArgs e)
    {
        Debug.WriteLine("bobs");
    }


    public void ChangePresenter(IPresenter presenter)
    {
        throw new NotImplementedException();
    }
}
