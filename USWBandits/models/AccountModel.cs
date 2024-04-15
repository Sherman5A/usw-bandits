namespace USWBandits.models;

public class AccountModel : IModel
{
    public ModelData ModelData { get; set; }

    public AccountModel(ModelData modelData)
    {
        ModelData = modelData;
    }
}
