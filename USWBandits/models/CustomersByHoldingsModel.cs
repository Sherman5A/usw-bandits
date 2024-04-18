using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using USWBandits.logic;

namespace USWBandits.models;

public class CustomersByHoldingsModel : IModel
{
    public ModelData ModelData { get; set; }

    public CustomersByHoldingsModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public List<(int customerId, string firstName, string lastName, decimal totalBalance)> GetMostValuableCustomers()
    {
        List<(int customerId, string firstName, string lastName, decimal totalBalance)> transactions = new();
        const string queryString =
            "SELECT account.custid, customer.firstname, customer.lastname, sum(account.balance) as 'totalHoldings' FROM account JOIN customer ON account.custid = customer.custid GROUP BY account.custid ORDER BY totalHoldings DESC;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    transactions.Add((
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDecimal(3)
                    ));
                }
            }
        }

        return transactions;
    }
}
