using System.Data.SQLite;

namespace USWBandits.models;

public class StatsModel : IModel
{
    public ModelData ModelData { get; set; }

    public StatsModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public int CalculateInterest()
    {
        const string queryString = "UPDATE account SET accrued = ROUND(accrued + (SELECT (account.balance * product.intrate / 365.0) FROM product WHERE account.prodid = product.prodid), 2), balance = ROUND(balance + (SELECT (account.balance * product.intrate / 365.0) FROM product WHERE account.prodid = product.prodid), 2);";

        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }
}