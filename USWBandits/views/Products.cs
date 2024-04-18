﻿using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Products : UserControl, IProducts
{
    public Products()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddProductClick;

    private void OnProductsLoad(object sender, EventArgs eventArgs)
    {
        ButtonAddProduct.Click += (s, e) => ButtonAddProductClick?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeProducts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeProducts");
    }
}
