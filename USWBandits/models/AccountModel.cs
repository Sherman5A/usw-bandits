using System.Data.SQLite;
using System.Diagnostics;
using USWBandits.logic;

namespace USWBandits.models;

public class AccountModel : IModel
{
    public ModelData ModelData { get; set; }


    public AccountModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public int GetAccountNumber()
    {
        const string queryString = "SELECT MAX(accid) FROM account;";
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
                while (reader.Read())
                {
                    returnList.Add((reader.GetInt16(0), reader.GetString(1), reader.GetString(2)));
                }
            }
        }

        return returnList;
    }

    public List<(int id, string isaName)> GetProducts()
    {
        // TODO: Shorten this stuff with a helper
        const string queryString = "SELECT prodid, isaname FROM product ORDER BY prodid;";
        List<(int id, string isaName)> returnList = new();
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    returnList.Add((reader.GetInt16(0), reader.GetString(1)));
                }
            }
        }

        return returnList;
    }

    public int AddAccount(BankAccount account)
    {
        const string queryString =
            @"INSERT INTO account(custid, prodid, balance, accrued) VALUES (@CustomerID, @ProductID, @Balance, @Accrued);";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@CustomerID", account.CustomerID);
            sqlCommand.Parameters.AddWithValue("@ProductID", account.ProductID);
            sqlCommand.Parameters.AddWithValue("@Balance", account.Balance);
            sqlCommand.Parameters.AddWithValue("@Accrued", account.Accrued);
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }
}
