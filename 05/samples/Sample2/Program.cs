Console.WriteLine("What is your birth year?");
var year = int.Parse(Console.ReadLine()!);
var age = DateTime.Now.Year - year;

switch (age)
{
    case < 18:
        Console.WriteLine("You are a minor");
        break;
    case < 65:
        Console.WriteLine("You are an adult");
        break;
    default:
        Console.WriteLine("You are a senior");
        break;
}