﻿using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class ConnectedHome : UserControl, IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public IPresenter Presenter { get; set; }

    public ConnectedHome()
    {
        InitializeComponent();
        sideNav.TreeNavSelect += (s, e) => TreeNavSelect?.Invoke(s, e);
    }
}
