using System.Data.SQLite;
using System.Globalization;
using USWBandits.logic;

namespace USWBandits.models;

public class SqlHelper
{
    public static List<BankAccount> GetAllAccounts(string sqlPath)
    {
        List<BankAccount> accounts = new();
        const string queryString = "SELECT accid, custid, prodid, balance, accrued FROM account;";
        using (var connection = new SQLiteConnection($@"Data Source={sqlPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    accounts.Add(new BankAccount(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetDecimal(3),
                        reader.GetDecimal(4))
                    );
                }
            }
        }

        return accounts;
    }

    public static List<BankProduct> GetAllProducts(string sqlPath)
    {
        List<BankProduct> products = new();
        const string queryString = "SELECT prodid, isaname, status, intrate FROM product;";
        using (var connection = new SQLiteConnection($@"Data Source={sqlPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    products.Add(new BankProduct(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetInt32(3)
                    ));
                }
            }
        }

        return products;
    }

    public static List<BankCustomer> GetAllCustomers(string sqlPath)
    {
        List<BankCustomer> customers = new();
        const string queryString =
            "SELECT custid, title, firstname, lastname, dob, nicode, email, password, allowance FROM customer;";
        using (var connection = new SQLiteConnection($@"Data Source={sqlPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    customers.Add(new BankCustomer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(6),
                        reader.GetString(7),
                        reader.GetString(5),
                        reader.GetDecimal(8),
                        DateOnly.FromDateTime(reader.GetDateTime(4))
                    ));
                }
            }
        }

        return customers;
    }

    public static List<BankTransaction> GetAllTransactions(string sqlPath)
    {
        List<BankTransaction> accounts = new();
        const string queryString = "SELECT trnxid, accid, action, amnt, event FROM tranx;";
        using (var connection = new SQLiteConnection($@"Data Source={sqlPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
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

                    accounts.Add(new BankTransaction(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetDecimal(3),
                        transactionEvent
                    ));
                }
            }
        }

        return accounts;
    }
}
