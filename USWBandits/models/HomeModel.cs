namespace USWBandits.models;

public class HomeModel : IModel
{
    public HomeModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }
}
