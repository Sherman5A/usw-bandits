﻿using USWBandits.views;

namespace USWBandits.presenters;

public class ProductsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IProducts View { get; set; }
    public override UserControl ViewControl => View as UserControl;

    public ProductsPresenter(Control parentControl, IProducts view)
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
