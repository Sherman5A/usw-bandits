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
    int Interest { get; set; }
    string GetAccountName();
    ProductOpenStatus? GetStatus();
    void ShowResult(int result);
    void ShowError(string message);
    void SetProductId(int productId);
}
