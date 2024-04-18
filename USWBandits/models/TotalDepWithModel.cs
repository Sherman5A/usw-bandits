using System.Data.SQLite;
using USWBandits.logic;

namespace USWBandits.models;

internal class TotalDepWithModel : IModel
{
    public TotalDepWithModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }

    /// <summary>
    /// Gets the sum of all transactions between 2 dates and of a certain transaction type
    /// </summary>
    public decimal GetTransactionTotal(DateTime lowerDate, DateTime upperDate, TransactionAction action)
    {
        const string queryString =
            "SELECT SUM(amnt) FROM tranx WHERE event BETWEEN @LowerDate AND @UpperDate AND action = @Action";

        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@LowerDate",
                lowerDate.ToString("yyyy:MM:dd HH:mm"));
            sqlCommand.Parameters.AddWithValue("@UpperDate",
                upperDate.ToString("yyyy:MM:dd HH:mm"));
            sqlCommand.Parameters.AddWithValue("@Action", TransactionHelper.StringFromTransaction(action));
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read()) return reader.GetDecimal(0);
            }
        }

        return -1;
    }

    public decimal GetTransactionTotal(DateTime lowerDate, DateTime upperDate)
    {
        // Overloaded method for not filtering by action
        const string queryString = @"SELECT SUM(amnt) FROM tranx WHERE event BETWEEN @LowerDate AND @UpperDate";

        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@LowerDate",
                lowerDate.ToString("yyyy:MM:dd HH:mm"));
            sqlCommand.Parameters.AddWithValue("@UpperDate",
                upperDate.ToString("yyyy:MM:dd HH:mm"));
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read()) return reader.GetDecimal(0);
            }
        }

        return -1;
    }
}
