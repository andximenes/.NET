class Program
{
    static void Main()
    {   
        //creating objects
        BankAccount account1 = new BankAccount("Andrew");
        BankAccount account2 = new BankAccount("Lucas");

        Console.WriteLine(account1.Balance);
        account1.Deposit(200);
        Console.WriteLine(account1.Balance);

    }
}


class BankAccount
{
    private string name;

    public decimal Balance 
    {
        get; private set;
        
    }

    //Parametrized constructor
    public BankAccount(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("invalid name", nameof(name));
        }

        this.name = name;
        Balance = 0;
    }

    //Deposit method
    public void Deposit(decimal amount)
    {
        try
        {
            if(amount <= 0)
            {
                throw new Exception("the value cannot be less than zero");
            }
            else
            {
                Balance += amount;
            }

        }
        catch (Exception exception)
        {
            
            Console.WriteLine($"the value cannot be less than zero, {exception.Message}");
        }
    }
   
}