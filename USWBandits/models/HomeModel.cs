namespace USWBandits.models;

public class HomeModel : IModel
{
    public ModelData ModelData { get; set; }

    public HomeModel(ModelData modelData)
    {
        ModelData = modelData;
    }
}
