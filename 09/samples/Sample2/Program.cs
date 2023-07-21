Console.WriteLine("What is your age?");
var age = int.Parse(Console.ReadLine()!);
const int legalAge = 18;

if (age >= legalAge)
{
    Console.WriteLine("You are old enough to vote.");
}
else
{
    throw new Exception("You are not old enough to vote.");
}
