using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using USWBandits.logic;

namespace USWBandits.models;

public class TransactionModel : IModel
{
    public ModelData ModelData { get; set; }

    public TransactionModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public int GetCurrentTransactionId()
    {
        const string queryString = "SELECT MAX(trnxid) FROM tranx;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }
            }
        }

        return -1;
    }

    public BankTransaction? GetTransactionByKey(int key)
    {
        const string queryString = @"SELECT trnxid, accid, action, amnt, event FROM tranx WHERE trnxid = @Key;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Key", key);
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
                    // catch impossible dates present in db like 2019:02:30 08:15 
                    catch (FormatException)
                    {
                        transactionEvent = DateTime.UnixEpoch;
                    }

                    return new BankTransaction(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetDecimal(3),
                        transactionEvent
                    );
                }
            }
        }

        return null;
    }

    public List<int> GetAccounts()
    {
        const string queryString = @"SELECT accid FROM account;";
        List<int> returnList = new();
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    returnList.Add((reader.GetInt32(0)));
                }
            }
        }

        return returnList;
    }

    public int AddTransaction(BankTransaction transaction)
    {
        const string queryString =
            @"INSERT INTO tranx(accid, action, amnt, event) 
              VALUES (@AccountID, @Action, @Amount, @Event);";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@AccountID", transaction.TranAccountID);
            sqlCommand.Parameters.AddWithValue("@Action", transaction.GetActionString());
            sqlCommand.Parameters.AddWithValue("@Amount", transaction.Amount);
            sqlCommand.Parameters.AddWithValue("@Event", transaction.Event.ToString("yyyy:MM:dd HH:mm"));
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public List<BankTransaction> GetTransactions()
    {
        return SqlHelper.GetAllTransactions(ModelData.SQLPath);
    }

    public int DeleteTransactionByKey(int transactionId)
    {
        Debug.WriteLine(transactionId);
        const string queryString =
            @"DELETE FROM tranx WHERE trnxid = @Key;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Key", transactionId);
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }
}
