namespace USWBandits.models;

public class GenericModel : IModel
{
    public ModelData ModelData { get; set; }

    public GenericModel(ModelData modelData)
    {
        ModelData = modelData;
    }
}
