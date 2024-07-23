class Program
{
    static void Main()
    {   
        //creating objects
        BankAccount account1 = new BankAccount("Andrew");
        BankAccount account2 = new BankAccount("Lucas");

        Console.WriteLine(account1.ViewBalance());
        account1.Deposit(200);
        Console.WriteLine(account1.ViewBalance());
        account1.WithDraw(300);
        Console.WriteLine(account1.ViewBalance());

    }
}


class BankAccount
{
    private string name;
    private decimal balance;

    //Parametrized constructor
    public BankAccount(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("invalid name", nameof(name));
        }

        if(balance < 0)
        {
            throw new Exception("the balance cannot be less than zero");
        }

        this.name = name;
        this.balance = 0;
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
                balance += amount;
            }

        }
        catch (Exception exception)
        {
            
            Console.WriteLine($"the value cannot be less than zero, {exception.Message}");
        }
    }

    //View Balance method
    public string ViewBalance()
    {
        return $"Current balance: ${this.balance}";
    }

    //ithDraw money method
    public void WithDraw( decimal value)
    {
        this.balance -= value;
    }
}