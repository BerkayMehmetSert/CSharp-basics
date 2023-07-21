Console.WriteLine("What is your birth year?");
var year = int.Parse(Console.ReadLine()!);
var age = DateTime.Now.Year - year;

var message = age switch
{
    < 18 => "You are a minor",
    < 65 => "You are an adult",
    _ => "You are a senior"
};

Console.WriteLine(message);