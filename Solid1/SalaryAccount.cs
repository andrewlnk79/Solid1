namespace Solid1;

public class SalaryAccount : Account
{
    public SalaryAccount(string type, double balance, double interest) : base(type, balance, interest)
    {
        
    }

    public void CalculateInterests()
    {
        Balance -= Interest * 0.5;
    }
}


