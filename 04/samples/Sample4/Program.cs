var random = new Random();
string[] cities = { "London", "Paris", "Milan", "New York", "Los Angeles" };

Console.WriteLine("Random number: " + random.Next());
Console.WriteLine("Random number between 0 and 99: " + random.Next(100));
Console.WriteLine("Random number between 1 and 10: " + random.Next(1, 11));
Console.WriteLine("Random city: " + cities[random.Next(cities.Length)]);