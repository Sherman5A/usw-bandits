﻿using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Home : UserControl, IHome
{
    public Home()
    {
        InitializeComponent();
    }

    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonCustomersClick;
    public event EventHandler? ButtonTransactionsClick;
    public event EventHandler? ButtonAccountsClick;
    public event EventHandler? ButtonProductsClick;

    private void OnHomeLoad(object sender, EventArgs eventArgs)
    {
        SideNav.FocusNode("NodeHome");
        ButtonProducts.Click += (s, e) => ButtonProductsClick?.Invoke(s, e);
        ButtonTransactions.Click += (s, e) => ButtonTransactionsClick?.Invoke(s, e);
        ButtonAccount.Click += (s, e) => ButtonAccountsClick?.Invoke(s, e);
        ButtonCustomers.Click += (s, e) => ButtonCustomersClick?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeHome") TreeNavSelect?.Invoke(s, e);
        };
    }
}
