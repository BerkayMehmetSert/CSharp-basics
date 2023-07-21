const string question1 = "a = 10, b = 5, c = 20 What is the value of a + b * c?";
const string question2 = "a = 10, b = 5, c = 20 What is the value of (a + b) * c?";
const string question3 = "a = 10, b = 20, a = b-- What is the value of a?";

var answer1 = 10 + 5 * 20;
var asnwer2 = (10 + 5) * 20;
var a = 10;
var b = 20;
a = b--;
var answer3 = a;

Console.WriteLine($"{question1}" +
                  $"\nAnswer: {answer1}" +
                  $"\n{question2}" +
                  $"\nAnswer: {asnwer2}" +
                  $"\n{question3}" +
                  $"\nAnswer: {answer3}");