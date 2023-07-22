namespace Solid1;

public abstract  class Account: ICalculateInterest
{
    public string Type;
    public double Balance;
    public double Interest;

     protected Account(string type, double balance, double interest)
     {
          Type = type;
          Balance = balance;
          Interest = interest;
     }
     

     
}