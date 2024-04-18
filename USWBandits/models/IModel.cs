namespace USWBandits.models;

/// <summary>
///     Models must interface with the presenter to provide them with business logic data
///     This could be through database, external API queries, etc...
/// </summary>
public interface IModel
{
    public ModelData ModelData { get; set; }
}
