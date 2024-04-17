using System.Data.SQLite;
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
                    return reader.GetInt16(0);
                }
            }
        }

        return -1;
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
}
