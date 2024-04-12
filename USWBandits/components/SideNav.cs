namespace USWBandits.components;

public partial class SideNav : UserControl
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public SideNav()
    {
        InitializeComponent();
    }

    public void FocusNode(string nodeName)
    {
        TreeNav.SelectedNode = TreeNav.Nodes.Find(nodeName, true)[0];
    }

    private void OnTreeNavAfterSelect(object sender, TreeViewEventArgs e)
    {
        string selectedNode = e.Node.Name;

        string? switchWindow = selectedNode switch
        {
            "NodeProducts" => "Products",
            "NodeAccounts" => "Accounts",
            "NodeCustomers" => "Customers",
            "NodeTransactions" => "Transactions",
            _ => null
        };

        TreeNavSelectArgs args = new()
        {
            SelectedNode = switchWindow ?? throw new InvalidOperationException()
        };
        TreeNavSelect?.Invoke(this, args);
    }
}

public class TreeNavSelectArgs : EventArgs
{
    public string SelectedNode { get; set; }
}
