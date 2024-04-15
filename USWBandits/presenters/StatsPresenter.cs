using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

internal class StatsPresenter : SideNavPresenters, IPresenter
{
    public override Control ParentControl { get; set; }
    public IStats View {  get; set; }
    public override UserControl ViewControl => View as UserControl;
    public GenericModel Model { get; set; }
    public override ModelData ModelData => Model.ModelData;

    public StatsPresenter(Control parentControl, IStats view, ModelData modelData)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.TreeNavSelect += OnTreeNavSelect;
        Model = new GenericModel(modelData);
    }

    public override void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
