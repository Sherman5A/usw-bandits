﻿using USWBandits.views;

namespace USWBandits.presenters;

public class HomePresenter : IPresenter
{
    public Control ParentControl { get; set; }
    public Home View { get; set; }
    public UserControl ViewControl => View;


    public HomePresenter(Control parentControl, Home view)
    {
        ParentControl = parentControl;
        View = view;
        View.Presenter = this;
    }

    public void ChangePresenter(IPresenter presenter)
    {
        throw new NotImplementedException();
    }
}
