using USWBandits.components;
using USWBandits.logic;

namespace USWBandits.views;

internal interface ITotalDepWith : IView
{
    DateTime LowerDate { get; set; }
    DateTime UpperDate { get; set; }
    TransactionAction? TransactionAction { get; set; }
    public event EventHandler<TreeNavSelectArgs> TreeNavSelect;
    public event EventHandler? ButtonStartQuery;
    void ShowResult(decimal result);
    void ShowError(string errorMessage);
}
