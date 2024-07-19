//Calculation your age

int currentYear = 2024;
string name;
int yearBirth;
int age;
int legalAge = 18;

Console.Write("Name: ");
name = Console.ReadLine();
Console.Write("Year of birth: ");
yearBirth = int.Parse(Console.ReadLine());

//creates a line
Console.WriteLine(string.Concat(Enumerable.Repeat("_", 50)));

//receives the calculation between the current year and the date of birth
age = currentYear - yearBirth;

Console.WriteLine($"{name}, you are {age} years old");

//verifies that you are of legal ange
if(age >= legalAge)
{
    Console.WriteLine("You are of legal age!");
}
else
{
    Console.WriteLine("Your are not of legal age!");
};


