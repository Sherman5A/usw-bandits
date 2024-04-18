using USWBandits.logic;

namespace USWBandits.models;

/// <summary>
///     A generic model for presenters that perform no specialist database queries
/// </summary>
public class GenericModel : IModel
{
    public GenericModel(ModelData modelData)
    {
        ModelData = modelData;
    }

    public ModelData ModelData { get; set; }

    public List<BankProduct> GetProducts()
    {
        return SqlHelper.GetAllProducts(ModelData.SQLPath);
    }

    public List<BankCustomer> GetCustomers()
    {
        return SqlHelper.GetAllCustomers(ModelData.SQLPath);
    }

    public List<BankAccount> GetAccounts()
    {
        return SqlHelper.GetAllAccounts(ModelData.SQLPath);
    }

    public List<BankTransaction> GetTransactions()
    {
        return SqlHelper.GetAllTransactions(ModelData.SQLPath);
    }
}
