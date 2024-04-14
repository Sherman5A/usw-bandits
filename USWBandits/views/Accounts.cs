﻿using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Accounts : UserControl, IAccounts
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public Accounts()
    {
        InitializeComponent();
    }

    private void OnAccountsLoad(object sender, EventArgs e)
    {
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeAccounts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeAccounts");
    }
}