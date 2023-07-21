for (var i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

// For each loop
int[] numbers = { 1, 2, 3, 4, 5 };

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();

// While loop
var j = 1;

while (j <= 5)
{
    Console.WriteLine(j);
    j++;
}

Console.WriteLine();

// Do while loop
var k = 1;

do
{
    Console.WriteLine(k);
    k++;
} while (k <= 5);