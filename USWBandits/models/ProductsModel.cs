namespace USWBandits.models;

public class ProductsModel : IModel
{
    public ModelData ModelData { get; set; }

    public ProductsModel(ModelData modelData)
    {
        ModelData = modelData;
    }
}
