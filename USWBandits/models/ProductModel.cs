namespace USWBandits.models;

public class ProductModel : IModel
{
    public ModelData ModelData { get; set; }

    public ProductModel(ModelData modelData)
    {
        ModelData = modelData;
    }
}
