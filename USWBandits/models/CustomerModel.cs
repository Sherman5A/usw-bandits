using System.Data.SQLite;
using USWBandits.logic;

namespace USWBandits.models;

public class CustomerModel : IModel
{
    public CustomerModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }

    public int GetCurrentCustomerId()
    {
        const string queryString = @"SELECT MAX(custid) FROM customer;";
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
    ///     Add a new customer to the customer database table
    /// </summary>
    /// <param name="customer">Customer to add</param>
    /// <returns></returns>
    public int AddCustomer(BankCustomer customer)
    {
        const string queryString =
            @"INSERT INTO customer(title, firstname, lastname, dob, nicode, email, password, allowance) 
              VALUES (@Title, @firstname, @Lastname, @DOB, @Nicode, @Email, @Password, @Allowance);";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Title", customer.Title);
            sqlCommand.Parameters.AddWithValue("@Firstname", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@Lastname", customer.LastName);
            // Format string to database standard
            sqlCommand.Parameters.AddWithValue("@DOB", customer.CustomerDob.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@Nicode", customer.NiNumber);
            sqlCommand.Parameters.AddWithValue("@Email", customer.Email);
            sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
            sqlCommand.Parameters.AddWithValue("@Allowance", customer.Allowance);
            var result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public int DeleteCustomerByKey(int customerId)
    {
        const string queryString =
            @"DELETE FROM customer WHERE custid = @Key;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Key", customerId);
            var result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public int EditCustomer(BankCustomer customer)
    {
        const string queryString =
            @"UPDATE customer SET title = @Title, firstname = @FirstName, lastname = @LastName, dob = @DOB, nicode = @NiCode, email = @Email, password = @Password, allowance = @Allowance WHERE custid = @CustomerId";

        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            sqlCommand.Parameters.AddWithValue("@Title", customer.Title);
            sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            // Format string to database standard
            sqlCommand.Parameters.AddWithValue("@DOB", customer.CustomerDob.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@NiCode", customer.NiNumber);
            sqlCommand.Parameters.AddWithValue("@Email", customer.Email);
            sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
            sqlCommand.Parameters.AddWithValue("@Allowance", customer.Allowance);
            var result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    /// <summary>
    ///     Query the database for a transaction record with the given key
    /// </summary>
    /// <param name="key">Key of the record to get</param>
    /// <returns>The retrieve record</returns>
    public BankCustomer? GetCustomerByKey(int key)
    {
        const string queryString =
            @"SELECT custid, title, firstname, lastname, dob, nicode, email, password, allowance FROM customer WHERE custid = @Key;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Key", key);
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                    return new BankCustomer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(6),
                        reader.GetString(7),
                        reader.GetString(5),
                        reader.GetDecimal(8),
                        DateOnly.FromDateTime(reader.GetDateTime(4))
                    );
            }
        }

        return null;
    }

    public List<BankCustomer> GetCustomers()
    {
        return SqlHelper.GetAllCustomers(ModelData.SQLPath);
    }
}
