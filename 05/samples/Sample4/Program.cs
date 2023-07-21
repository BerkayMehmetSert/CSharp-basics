// Calculate Machine

Console.WriteLine("Select an operation:");
Console.WriteLine("1 - Sum");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Multiply");
Console.WriteLine("4 - Divide");
Console.WriteLine("Option: ");
var option = int.Parse(Console.ReadLine()!);

Console.WriteLine("First number: ");
var firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Second number: ");
var secondNumber = int.Parse(Console.ReadLine()!);

var result = option switch
{
    1 => firstNumber + secondNumber,
    2 => firstNumber - secondNumber,
    3 => firstNumber * secondNumber,
    4 => firstNumber / secondNumber,
    _ => 0
};

Console.WriteLine("Result: " + result);