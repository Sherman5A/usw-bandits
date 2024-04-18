using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

/// <summary>
/// Contract between Product and StartProduct
/// </summary>
public interface IProduct : IView
{
    public event EventHandler<TreeNavSelectArgs>? TreeNavSelect;
    public event EventHandler? ButtonAddProductClicked;
    public event EventHandler? ButtonEditProductClicked;
    public event EventHandler? ButtonDeleteProductClicked;

    decimal Interest { get; set; }
    int ProductId { get; set; }
    string AccountName { get; set; }
    ProductOpenStatus? ProductStatus { get; set; }
    void ShowResult(int result);
    void ShowError(string message);
    void AddNavItems(List<BankProduct> products);
    void EditMode();
}
