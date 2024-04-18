﻿using USWBandits.logic;
using USWBandits.models;
using USWBandits.views;


namespace USWBandits.presenters;

internal class TotalDepWithPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public ITotalDepWith View { get; set; }
    public TotalDepWithModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;
    public override UserControl ViewControl => View as UserControl;

    public TotalDepWithPresenter(Control parentControl, ITotalDepWith view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        View.ButtonStartQuery += OnStartQuery;
        Model = new TotalDepWithModel(modelData);
    }

    private void OnStartQuery(object? sender, EventArgs e)
    {
        DateTime fromDate = View.LowerDate;
        DateTime toDate = View.UpperDate;
        TransactionAction? action = View.TransactionAction;
        decimal result;
        if (action is null)
            result = Model.GetTransactionTotal(fromDate, toDate);
        else
        {
            result = Model.GetTransactionTotal(fromDate, toDate, (TransactionAction)action);
        }

        if (result >= 0)
        {
            View.ShowResult(result);
        }
        else
        {
            View.ShowError($"Unable to find total transactions of type {action}");
        }
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
