const string message = "Hello World!";
Console.WriteLine(message[0]);

string[] names = new string[5];
names[0] = "John";
names[1] = "Mary";
names[2] = "Bob";
names[3] = "Alice";
names[4] = "Joe";

int[] numbers = { 10, 20, 30, 40, 50 };

Console.WriteLine($"{names[0]} is {numbers[0]} years old.");
Console.WriteLine($"{names[1]} is {numbers[1]} years old.");
Console.WriteLine($"{names[2]} is {numbers[2]} years old.");
Console.WriteLine($"{names[3]} is {numbers[3]} years old.");
Console.WriteLine($"{names[4]} is {numbers[4]} years old.");

Console.WriteLine();

int x = 10;
int y = x;

Console.WriteLine(x);
Console.WriteLine(y);

x = 20;

Console.WriteLine(x);
Console.WriteLine(y);

Console.WriteLine();

int[] xArray = { 10, 20 };
int[] yArray = xArray;

Console.WriteLine(xArray[0]);
Console.WriteLine(yArray[0]);

xArray[0] = 30;

Console.WriteLine(xArray[0]);
Console.WriteLine(yArray[0]);