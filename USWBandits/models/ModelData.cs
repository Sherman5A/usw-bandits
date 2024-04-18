namespace USWBandits.models;

/// <summary>
///     Stores persistent model data
/// </summary>
public class ModelData
{
    /// <summary>
    ///     Initialise class
    /// </summary>
    /// <param name="sqlPath">File path of the database</param>
    public ModelData(string sqlPath)
    {
        SQLPath = sqlPath;
    }

    /// <summary>
    ///     Path of the database for use in queries
    /// </summary>
    public string SQLPath { get; set; }
}
