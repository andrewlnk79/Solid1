namespace Solid1;

public class RegularAccount : Account
{
    public RegularAccount(string type, double balance, double interest) : base(type, balance, interest)
    {
    }
    void CalculateInterests()
    {
        if (Balance < 1000)
        {
            Interest -= Balance * 0.2;
        }

        else
        {
            Interest -= Balance * 0.4;

        }
    }
}