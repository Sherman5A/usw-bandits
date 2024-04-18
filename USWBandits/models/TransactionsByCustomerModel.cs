using System.Data.SQLite;
using System.Globalization;
using USWBandits.logic;

namespace USWBandits.models;

public class TransactionsByCustomerModel : IModel
{
    public TransactionsByCustomerModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }

    public List<BankTransaction> GetTransactionsByCustomer(int customerKey)
    {
        List<BankTransaction> transactions = new();
        const string queryString =
            "SELECT event, trnxid, tranx.accid, action, amnt FROM tranx JOIN account ON tranx.accid = account.accid WHERE account.custid = @CustomerKey ORDER BY tranx.event ASC";

        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@CustomerKey",
                customerKey);
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime transactionEvent;
                    try
                    {
                        transactionEvent = DateTime.ParseExact(reader.GetString(0), "yyyy:MM:dd HH:mm",
                            CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        transactionEvent = DateTime.UnixEpoch;
                    }

                    transactions.Add(new BankTransaction(
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3),
                        reader.GetDecimal(4),
                        transactionEvent
                    ));
                }
            }
        }

        return transactions;
    }

    public List<(int id, string firstName, string lastName)> GetCustomers()
    {
        const string queryString = "SELECT custid, firstname, lastname FROM customer ORDER BY custid;";
        List<(int, string, string)> returnList = new();
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read()) returnList.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
        }

        return returnList;
    }
}
