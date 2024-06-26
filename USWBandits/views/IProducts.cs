﻿using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

/// <summary>
///     Contract between Products and ProductsPresenter
/// </summary>
public interface IProducts : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    event EventHandler? ButtonAddProductClick;
    void AddNavItems(List<BankProduct> products);
}
