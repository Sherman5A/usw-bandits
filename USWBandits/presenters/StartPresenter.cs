using System.Data.SQLite;
using System.Diagnostics;
using USWBandits.models;
using USWBandits.views;

namespace USWBandits.presenters;

public class StartPresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public IStart View { get; set; }
    public StartModel Model { get; set; }
    public UserControl ViewControl => View as UserControl;
    public SQLiteConnection Conn { get; set; }

    public StartPresenter(Control parentControl, IStart view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
        View.ConnectDatabase += HandleDatabaseConnect;
    }

    private void HandleDatabaseConnect(object? sender, ConnectDatabaseEventArgs e)
    {
        if (!File.Exists(@e.DatabasePath))
        {
            return;
        };

        Model = new StartModel( new ModelData(@e.DatabasePath));
        ChangePresenter(new HomePresenter(ParentControl, new Home(), Model.ModelData));
    }

    public void ChangePresenter(IPresenter presenter)
    {
        ParentControl.GoTo(presenter);
    }
}
