using System.Data.SQLite;

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
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "SELECT MAX(accid) FROM account;";
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
        List<(int, string, string)> returnList = new();
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "SELECT custid, firstname, lastname FROM customer ORDER BY custid;";
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
        List<(int id, string isaName)> returnList = new();
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "SELECT prodid, isaname FROM product ORDER BY prodid;";
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
}
