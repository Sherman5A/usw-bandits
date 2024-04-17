﻿using USWBandits.components;
using USWBandits.presenters;

namespace USWBandits.views;

public partial class Account : UserControl, IAccount
{
    public IPresenter? Presenter { get; set; }
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddAccountClicked;

    public Account()
    {
        InitializeComponent();
    }

    private void OnAccountLoad(object sender, EventArgs eventArgs)
    {
        NumericBalance.Maximum = decimal.MaxValue;
        NumericAccrued.Maximum = decimal.MaxValue;
        ButtonAdd.Click += (s, e) => ButtonAddAccountClicked?.Invoke(s, e);
        SideNav.TreeNavSelect += (s, e) =>
        {
            if (e.SelectedNode != "NodeAccounts") TreeNavSelect?.Invoke(s, e);
        };
        SideNav.FocusNode("NodeAccounts");
    }

    public void SetAccountId(int accID)
    {
        LabelAccountID.Text = accID.ToString();
    }

    public void SetCustomerOptions(List<(int id, string firstName, string lastName)> customers)
    {
        Dictionary<int, string> optionsDict = new();
        foreach (var item in customers)
        {
            optionsDict.Add(item.id, $"ID: {item.id} - {item.firstName} {item.lastName}");
        }

        ComboCustomerID.DataSource = new BindingSource(optionsDict, null);
        ComboCustomerID.DisplayMember = "Value";
        ComboCustomerID.ValueMember = "Key";
    }

    public int GetCustomerID() => ((KeyValuePair<int, string>)ComboCustomerID.SelectedItem).Key;

    public void SetProductOptions(List<(int id, string isaName)> products)
    {
        Dictionary<int, string> optionsDict = new();
        foreach (var item in products)
        {
            optionsDict.Add(item.id, $"ID: {item.id} - {item.isaName}");
        }

        ComboProductID.DataSource = new BindingSource(optionsDict, null);
        ComboProductID.DisplayMember = "Value";
        ComboProductID.ValueMember = "Key";
    }

    public void ShowResult(int addResult)
    {
        MessageBox.Show($"Database added {addResult} rows");
    }

    public decimal Balance
    {
        get => NumericBalance.Value;
        set => NumericBalance.Value = value;
    }

    public decimal Accrued
    {
        get => NumericAccrued.Value;
        set => NumericAccrued.Value = value;
    }

    public int GetProductID() => ((KeyValuePair<int, string>)ComboProductID.SelectedItem).Key;
}
