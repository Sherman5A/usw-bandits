namespace USWBandits.model;

public class Customer
{
    // DB Info
    public int CustID { get; }
    public string CustTitle { get; }
    public string CustFirstName { get; }
    public string CustLastName { get; }
    public string CustEmail { get; }
    public string CustPassword { get; }
    public string CustNationalInsurance { get; }
    public decimal CustAllowance { get; }
    public DateOnly CustDOB { get; }
}
