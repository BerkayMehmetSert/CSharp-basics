Console.WriteLine("What is your First Name?");
var firstName = Console.ReadLine();
Console.WriteLine("What is your Last Name?");
var lastName = Console.ReadLine();
Console.WriteLine("What is your Age?");
var age = Console.ReadLine();

// Concatenation
var biography = "First Name: " + firstName + "\n" +
                "Last Name: " + lastName + "\n" +
                "Age: " + age;

// String Interpolation
var biography2 = $"First Name: {firstName}, Last Name: {lastName}, Age: {age}";
Console.WriteLine(biography);
Console.WriteLine(biography2);