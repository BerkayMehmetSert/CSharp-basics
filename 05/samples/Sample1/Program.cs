Console.WriteLine("What is your birth year?");
var year = int.Parse(Console.ReadLine()!);
var age = DateTime.Now.Year - year;

if (age < 18)
{
    Console.WriteLine("You are a minor");
}
else if (age < 65)
{
    Console.WriteLine("You are an adult");
}
else
{
    Console.WriteLine("You are a senior");
}