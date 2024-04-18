using System.Data.SQLite;
using USWBandits.logic;

namespace USWBandits.models;

public class ProductModel : IModel
{
    public ModelData ModelData { get; set; }

    public ProductModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public int GetCurrentProductId()
    {
        const string queryString = @"SELECT MAX(prodid) FROM product;";
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

    public int AddProduct(BankProduct product)
    {
        const string queryString =
            @"INSERT INTO product(isaname, status, intrate) 
              VALUES (@IsaName, @Status, @InterestRate);";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@IsaName", product.AccountName);
            sqlCommand.Parameters.AddWithValue("@Status", product.ProductStatus.ToString());
            sqlCommand.Parameters.AddWithValue("@InterestRate", product.ProductInterest);
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public int DeleteProductByKey(int productId)
    {
        const string queryString =
            @"DELETE FROM product WHERE prodid = @Key;";
        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();
            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@Key", productId);
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public int EditProduct(BankProduct product)
    {
        const string queryString =
            @"UPDATE product SET isaname = @IsaName, status = @Status, intrate = @InterestRate WHERE prodid = @ProductId";

        using (var connection = new SQLiteConnection($@"Data Source={ModelData.SQLPath}"))
        {
            connection.Open();

            var sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = queryString;
            sqlCommand.Parameters.AddWithValue("@ProductId", product.ProductID);
            sqlCommand.Parameters.AddWithValue("@IsaName", product.AccountName);
            sqlCommand.Parameters.AddWithValue("@Status", product.ProductStatus.ToString());
            sqlCommand.Parameters.AddWithValue("@InterestRate", product.ProductInterest);
            int result = sqlCommand.ExecuteNonQuery();
            return result;
        }
    }

    public List<BankProduct> GetTransactions()
    {
        return SqlHelper.GetAllProducts(ModelData.SQLPath);
    }

    public BankProduct? GetProductByKey(int key)
    {
        const string queryString = "SELECT prodid, isaname, status, intrate FROM product WHERE prodid = @Key";
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
                    return new BankProduct(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDecimal(3)
                    );
                }
            }
        }

        return null;
    }
}
