namespace USWBandits.logic;

public class BankCustomer
{
    public int CustomerID { get; }
    public string Title { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string Password { get; }
    public string NINUmber { get; }
    public decimal Allowance { get; }
    public DateOnly CustomerDOB { get; }

    public BankCustomer(int customerId, string title, string firstName, string lastName, string email, string password,
        string ninUmber, decimal allowance, DateOnly customerDob)
    {
        CustomerID = customerId;
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        NINUmber = ninUmber;
        Allowance = allowance;
        CustomerDOB = customerDob;
    }
}
