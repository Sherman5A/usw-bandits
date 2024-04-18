using System.Data.SQLite;
using USWBandits.logic;

namespace USWBandits.models;

public class AccountModel : IModel
{
    public AccountModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }

    /// <summary>
    ///     Get the highest accid
    /// </summary>
    /// <returns>Highest account id key</returns>
    public int GetAccountNumber()
    {
        const string queryString = @"SELECT MAX(accid) FROM account;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read()) return reader.GetInt16(0);
            }
        }

        return -1;
    }

    /// <summary>
    ///     Get an ordered list of customers
    /// </summary>
    /// <returns>Ordered list of tuples containing custid</returns>
    public List<int> GetCustomers()
    {
        const string queryString = @"SELECT custid FROM customer ORDER BY custid;";
        List<int> returnList = new();
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read()) returnList.Add(reader.GetInt32(0));
            }
        }

        return returnList;
    }

    /// <summary>
    ///     Get an ordered list of products
    /// </summary>
    /// <returns>Ordered list of prodid</returns>
    public List<int> GetProducts()
    {
        const string queryString = @"SELECT prodid FROM product ORDER BY prodid;";
        List<int> returnList = new();
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read()) returnList.Add(reader.GetInt16(0));
            }
        }

        return returnList;
    }

    /// <summary>
    ///     Add an account to the accounts table
    /// </summary>
    /// <param name="account">Account to add to table</param>
    /// <returns>Number of tables affected by query</returns>
    public int AddAccount(BankAccount account)
    {
        const string queryString =
            @"INSERT INTO account(custid, prodid, balance, accrued) VALUES (@CustomerId, @ProductID, @Balance, @Accrued);";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@CustomerId", account.CustomerID);
            sqlCommand.Parameters.AddWithValue("@ProductID", account.ProductID);
            sqlCommand.Parameters.AddWithValue("@Balance", account.Balance);
            sqlCommand.Parameters.AddWithValue("@Accrued", account.Accrued);
            var result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public BankAccount? GetAccountByKey(int key)
    {
        const string queryString = "SELECT accid, custid, prodid, balance, accrued FROM account WHERE accid = @Key;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Key", key);
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                    return new BankAccount(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetDecimal(3),
                        reader.GetDecimal(4));
            }
        }

        return null;
    }

    public int DeleteAccountByKey(int accountId)
    {
        const string queryString =
            @"DELETE FROM account WHERE accid = @Key;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Key", accountId);
            var result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public int EditAccount(BankAccount account)
    {
        const string queryString =
            @"UPDATE account SET custid = @CustomerId, prodid = @ProductId, balance = @Balance, accrued = @Accrued WHERE accid = @AccountId";

        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@AccountId", account.AccountID);
            sqlCommand.Parameters.AddWithValue("@CustomerId", account.CustomerID);
            sqlCommand.Parameters.AddWithValue("@ProductId", account.ProductID);
            sqlCommand.Parameters.AddWithValue("@Balance", account.Balance);
            sqlCommand.Parameters.AddWithValue("@Accrued", account.Accrued);
            var result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }


    /// <summary>
    ///     Get all records in the account table
    /// </summary>
    /// <returns>List of records placed into BankAccount class</returns>
    public List<BankAccount> GetAccounts()
    {
        return SqlHelper.GetAllAccounts(ModelData.SQLPath);
    }
}
