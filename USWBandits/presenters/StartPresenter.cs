using System.Data.SQLite;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class StartPresenter : IPresenter
{
    public StartPresenter(Control parentControl, IStart view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.ConnectDatabase += HandleDatabaseConnect;
    }

    public IStart View { get; set; }
    public StartModel Model { get; set; }
    public Control ParentControl { get; set; }
    public UserControl ViewControl => View as UserControl;

    public void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }

    private void HandleDatabaseConnect(object? sender, ConnectDatabaseEventArgs e)
    {
        if (!File.Exists(e.DatabasePath)) return;

        ParentControl.SetConnectionStatus(true);

        Model = new StartModel(new ModelData(e.DatabasePath));
        ChangePresenter(new HomePresenter(ParentControl, new Home(), Model.ModelData));
    }
}
