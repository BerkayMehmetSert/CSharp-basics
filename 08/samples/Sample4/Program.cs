var dictionary = new Dictionary<string, string>();
dictionary.Add("key1", "value1");
dictionary.Add("key2", "value2");

foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + " " + item.Value);
}