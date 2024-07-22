
string[] names = {"Andrew", "Bruno", "Cláudio"};

if(string.Equals(names[0], "andrew", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Same names");
}
else
{
    Console.WriteLine("Different names");
}


bool equals = string.Equals(names[0], "andrew", StringComparison.OrdinalIgnoreCase);
Console.WriteLine(equals);
