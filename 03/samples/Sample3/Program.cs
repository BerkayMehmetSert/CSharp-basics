string[] students = new string[3];

const string question = "What is your student name?";

Console.WriteLine(question);
students[0] = Console.ReadLine() ?? "";

Console.WriteLine(question);
students[1] = Console.ReadLine() ?? "";

Console.WriteLine(question);
students[2] = Console.ReadLine() ?? "";

var arrayLength = students.Length;
var firstAndLast = students[..2];

Console.WriteLine("Array length: {0}", arrayLength);
Console.WriteLine("First and last students: {0}", string.Join(", ", firstAndLast));