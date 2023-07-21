const string courseName = "C# Programming Language with .NET 7";

const string question1 = "How many characters does the course name have?";
const string question2 = "Make the course name lowercase.";
const string question3 = "Does it start with a period?";
const string question4 = "Where is the knowledge of C# located?";
const string question5 = "Does it contain the string 'C#'?";

var answer1 = courseName.Length;
var answer2 = courseName.ToLower();
var answer3 = courseName.StartsWith('.');
var answer4 = courseName.IndexOf("C#");
var answer5 = courseName.Contains("C#");

Console.WriteLine(courseName);
Console.WriteLine("Question 1: " + question1);
Console.WriteLine("Answer 1: " + answer1);
Console.WriteLine("Question 2: " + question2);
Console.WriteLine("Answer 2: " + answer2);
Console.WriteLine("Question 3: " + question3);
Console.WriteLine("Answer 3: " + answer3);
Console.WriteLine("Question 4: " + question4);
Console.WriteLine("Answer 4: " + answer4);
Console.WriteLine("Question 5: " + question5);
Console.WriteLine("Answer 5: " + answer5);