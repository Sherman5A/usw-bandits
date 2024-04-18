using System.Data.SQLite;
using System.Globalization;
using USWBandits.logic;

namespace USWBandits.models;

public class TransactionsByCustomerModel : IModel
{
    public ModelData ModelData { get; set; }

    public TransactionsByCustomerModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public List<BankTransaction> GetTransactionsByCustomer(int customerKey)
    {
        List<BankTransaction> transactions = new();
        const string queryString = "SELECT event, accid, action, amount FROM tranx JOIN account ON tranx.accid = account.accid WHERE account.custid = @CustomerKey ORDER BY tranx.event ASC";

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
                        transactionEvent = DateTime.ParseExact(reader.GetString(4), "yyyy:MM:dd HH:mm",
                            CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        transactionEvent = DateTime.UnixEpoch;
                    }
                    transactions.Add(new BankTransaction(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetDecimal(3),
                        transactionEvent
                        ));
                }
            }
        }
        return transactions;
    }
}