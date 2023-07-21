try
{
    Console.WriteLine("Number 1: ");
    var number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number 2: ");
    var number2 = Convert.ToInt32(Console.ReadLine());
    var result = number1 / number2;
    Console.WriteLine("Result: " + result);
} catch (Exception)
{
    Console.WriteLine("Invalid input");
}
