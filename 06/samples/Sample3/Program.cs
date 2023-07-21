int[] numbers = { 1, 2, 3, 4, 5 };

foreach (var number in numbers)
{
    if (number == 3) continue;
    Console.WriteLine(number);
}

Console.WriteLine();

foreach (var number in numbers)
{
    if (number == 3) break;
    Console.WriteLine(number);
}