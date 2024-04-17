using System.Data.SQLite;
using USWBandits.logic;

namespace USWBandits.models;

public class CustomerModel : IModel
{
    public ModelData ModelData { get; set; }

    public CustomerModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public int GetCurrentCustomerId()
    {
        const string queryString = "SELECT MAX(custid) FROM customer;";
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

    /// <summary>
    /// Add a new customer to the customer database table
    /// </summary>
    /// <param name="customer">Customer to add</param>
    /// <returns></returns>
    public int AddCustomer(BankCustomer customer)
    {
        const string queryString =
            @"INSERT INTO customer(title, firstname, lastname, dob, nicode, email, password, allowance) 
              VALUES (@Title, @Firstname, @Lastname, @DOB, @Nicode, @Email, @Password, @Allowance);";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Title", customer.Title);
            sqlCommand.Parameters.AddWithValue("@Firstname", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@Lastname", customer.LastName);
            // Format string to database standard
            sqlCommand.Parameters.AddWithValue("@DOB", customer.CustomerDOB.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@Nicode", customer.NiNumber);
            sqlCommand.Parameters.AddWithValue("@Email", customer.Email);
            sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
            sqlCommand.Parameters.AddWithValue("@Allowance", customer.Allowance);
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }
}
