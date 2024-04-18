namespace USWBandits.logic;

public class BankCustomer
{
    public BankCustomer(int customerId, string title, string firstName, string lastName, string email, string password,
        string niNumber, decimal allowance, DateOnly customerDob)
    {
        CustomerId = customerId;
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        NiNumber = niNumber;
        Allowance = allowance;
        CustomerDob = customerDob;
    }

    public int CustomerId { get; }
    public string Title { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public DateOnly CustomerDob { get; }
    public string NiNumber { get; }
    public string Email { get; }
    public string Password { get; }
    public decimal Allowance { get; }
}
