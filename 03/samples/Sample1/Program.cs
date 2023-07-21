string[] cities = { "London", "Paris", "Milan", "New York", "Seattle" };
int[] codes = { 10, 20, 30, 40, 50, 60 };

var firstCity = cities.First();
var lastCity = cities.Last();
var secondCity = cities[1];
var arrayLength = cities.Length;
var indexOfMilan = Array.IndexOf(cities, "Milan");
var slice = cities[1..3];

Console.WriteLine("First city: {0}", firstCity);
Console.WriteLine("Last city: {0}", lastCity);
Console.WriteLine("Second city: {0}", secondCity);
Console.WriteLine("Array length: {0}", arrayLength);
Console.WriteLine("Index of Milan: {0}", indexOfMilan);
Console.WriteLine("Slice: {0}", string.Join(", ", slice));

Console.WriteLine("Cities: {0}", string.Join(", ", cities));
Array.Sort(cities);
Console.WriteLine("Sorted cities: {0}", string.Join(", ", cities));
Array.Reverse(cities);
Console.WriteLine("Reversed cities: {0}", string.Join(", ", cities));
Array.Clear(cities, 0, 2);
Console.WriteLine("Cleared cities: {0}", string.Join(", ", cities));

Console.WriteLine("Codes: {0}", string.Join(", ", codes));
Array.Sort(codes);
Console.WriteLine("Sorted codes: {0}", string.Join(", ", codes));
Array.Reverse(codes);
Console.WriteLine("Reversed codes: {0}", string.Join(", ", codes));
Array.Clear(codes, 0, 2);
Console.WriteLine("Cleared codes: {0}", string.Join(", ", codes));