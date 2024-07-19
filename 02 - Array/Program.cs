class Program
{
    static void Main()
    {
        string[] names = {"Andrew", "Marcos", "Vinicius", "Paulo"};

        //Printing all elements of the Array
        
        /*for(int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }*/
        
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}

