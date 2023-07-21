// Value Types

int number = 0;
string str = "Hello World";
double doubleNumber = 3.14;
decimal decimalNumber = 3.14m;
bool isActive = true;
DateTime dateTime = DateTime.Now;

Console.WriteLine("Number: " + number);
Console.WriteLine("String: " + str);
Console.WriteLine("Double: " + doubleNumber);
Console.WriteLine("Decimal: " + decimalNumber);
Console.WriteLine("Boolean: " + isActive);
Console.WriteLine("DateTime: " + dateTime);

// Value Type Conversion
Console.WriteLine("Number 1: ");
var number1 = Console.ReadLine();
Console.WriteLine("Number 2: ");
var number2 = Console.ReadLine();
Console.WriteLine("--------------------");

Console.WriteLine("Number 1 type: " + number1.GetType());
Console.WriteLine("Number 2 type: " + number2.GetType());

var convertedNumber1 = Convert.ToInt32(number1); // Convert string to int
var convertedNumber2 = Convert.ToInt32(number2); // Convert string to int

Console.WriteLine("Number 1 type: " + convertedNumber1.GetType());
Console.WriteLine("Number 2 type: " + convertedNumber2.GetType());

// Nullable Types
int age; // Error
int? phone = null; // Nullable type