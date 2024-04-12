namespace USWBandits.presenters;

public interface IPresenter
{
    public Control ParentControl { get; set; }
    public UserControl ViewControl { get; }
    void ChangePresenter(IPresenter presenter);
}
