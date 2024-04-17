using USWBandits.logic;

namespace USWBandits.components;

public partial class SideNav : UserControl
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;

    public SideNav()
    {
        InitializeComponent();
    }

    public void AddItem(List<BankAccount> accounts)
    {
        List<TreeNode> accountNodes = new();
        foreach (var account in accounts)
        {
            var node = new TreeNode(account.AccountID.ToString())
            {
                Name = $"Account-{account.AccountID}"
            };
            accountNodes.Add(node);
        }

        TreeNav.Nodes.Find("NodeAccounts", false)[0].Nodes.AddRange(accountNodes.ToArray());
        ExpandNode("NodeAccounts");
    }

    public void AddItem(List<BankCustomer> customers)
    {
        List<TreeNode> customerNodes = new();
        foreach (var account in customers)
        {
            var node = new TreeNode($@"{account.CustomerID} - {account.FirstName}")
            {
                Name = $"Customer-{account.CustomerID}"
            };
            customerNodes.Add(node);
        }

        TreeNav.Nodes.Find("NodeCustomers", false)[0].Nodes.AddRange(customerNodes.ToArray());
        ExpandNode("NodeCustomers");
    }

    public void AddItem(List<BankTransaction> transactions)
    {
        List<TreeNode> accountNodes = new();
        foreach (var account in transactions)
        {
            var node = new TreeNode(account.TransactionID.ToString())
            {
                Name = $"Transaction-{account.TransactionID}"
            };
            accountNodes.Add(node);
        }

        TreeNav.Nodes.Find("NodeTransactions", false)[0].Nodes.AddRange(accountNodes.ToArray());
        ExpandNode("NodeTransactions");
    }

    public void AddItem(List<BankProduct> products)
    {
        List<TreeNode> accountNodes = new();
        foreach (var account in products)
        {
            var node = new TreeNode(account.ProductID.ToString())
            {
                Name = $"Product-{account.ProductID}"
            };
            accountNodes.Add(node);
        }

        TreeNav.Nodes.Find("NodeProducts", false)[0].Nodes.AddRange(accountNodes.ToArray());
        ExpandNode("NodeProducts");
    }

    private void ExpandNode(string nodeName)
    {
        TreeNav.Nodes.Find(nodeName, true)[0].Expand();
    }


    public void FocusNode(string nodeName)
    {
        TreeNav.SelectedNode = TreeNav.Nodes.Find(nodeName, true)[0];
    }

    private void OnTreeNavAfterSelect(object sender, TreeViewEventArgs e)
    {
        string selectedNode = e.Node.Name;
        TreeNavSelectArgs args = new()
        {
            SelectedNode = selectedNode
        };
        TreeNavSelect?.Invoke(this, args);
    }
}

public class TreeNavSelectArgs : EventArgs
{
    public string SelectedNode { get; set; }
}
