Console.WriteLine("Number: ");
var number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

// Ternary operator
var result = number % 2 == 0 ? "Even" : "Odd";
Console.WriteLine("Ternary operator: " + result);