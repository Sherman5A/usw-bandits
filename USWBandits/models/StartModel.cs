namespace USWBandits.models;

public class StartModel : IModel
{
    public StartModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }
}
