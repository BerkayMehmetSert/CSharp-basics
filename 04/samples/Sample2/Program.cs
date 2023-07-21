const string question = "Number: ";
Console.WriteLine(question);
var input = Console.ReadLine();
var number = Convert.ToInt32(input);
var result = number > 0 ? "Positive" : "Negative";
Console.WriteLine($"The number {number} is {result}");

Console.WriteLine();

Console.WriteLine(question);
input = Console.ReadLine();
number = Convert.ToInt32(input);
result = number % 2 == 0 ? "Even" : "Odd";
Console.WriteLine($"The number {number} is {result}");