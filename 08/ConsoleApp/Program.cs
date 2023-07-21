using System.Collections;

var list = new ArrayList();
int[] numbers = { 1, 2, 3, 4, 5 };

list.Add(1);
list.Add("Hello World!");
list.Add(true);
list.Add(null);
list.Add(new object());
list.AddRange(numbers);
list.Remove(null);

foreach (var item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine();

var genericList = new List<int>();
int[] numbers2 = { 1, 2, 3, 4, 5 };
genericList.Add(1);
genericList.Add(2);
//genericList.Add("Hello World!"); // Error
genericList.AddRange(numbers2);

foreach (var item in genericList)
{
    Console.WriteLine(item);
}