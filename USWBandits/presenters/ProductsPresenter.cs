﻿using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class ProductsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IProducts View { get; set; }
    public ProductsModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;


    public ProductsPresenter(Control parentControl, IProducts view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        Model = new ProductsModel(modelData);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
