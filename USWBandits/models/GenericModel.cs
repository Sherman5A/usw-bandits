namespace USWBandits.models;

public class GenericModel
{
    public ModelData ModelData { get; set; }

    public GenericModel(ModelData modelData)
    {
        ModelData = modelData;
    }
}
