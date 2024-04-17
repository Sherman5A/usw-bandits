namespace USWBandits.logic;

public class BankCustomer
{
    public int CustomerID { get; }
    public string Title { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public DateOnly CustomerDOB { get; }
    public string NiNumber { get; }
    public string Email { get; }
    public string Password { get; }
    public decimal Allowance { get; }

    public BankCustomer(int customerId, string title, string firstName, string lastName, string email, string password,
        string niNumber, decimal allowance, DateOnly customerDob)
    {
        CustomerID = customerId;
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        NiNumber = niNumber;
        Allowance = allowance;
        CustomerDOB = customerDob;
    }
}
