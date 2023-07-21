int[] numbers = { 1, 2, 3, 4, 5 };

for (var i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 3) continue;
    Console.WriteLine(numbers[i]);
}

Console.WriteLine();

for (var i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 3) break;
    Console.WriteLine(numbers[i]);
}