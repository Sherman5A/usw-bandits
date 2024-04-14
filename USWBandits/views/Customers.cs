﻿using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Customers : UserControl, ICustomers
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Customers()
    {
        InitializeComponent();
    }

    private void OnCustomersLoad(object sender, EventArgs eventArgs)
    {
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeCustomers") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeCustomers");
    }
}