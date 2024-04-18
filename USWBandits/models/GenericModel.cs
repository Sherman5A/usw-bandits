namespace USWBandits.models;

/// <summary>
///     A generic model for presenters that perform no database queries
/// </summary>
public class GenericModel : IModel
{
    public GenericModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }
}
