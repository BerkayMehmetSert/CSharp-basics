string[] cities = { "London", "Paris", "Milan", "New York", "Seattle" };

foreach (var city in cities)
{
    Console.WriteLine(city);
}

Console.WriteLine();

foreach (var city in cities[..2])
{
    Console.WriteLine(city);
}