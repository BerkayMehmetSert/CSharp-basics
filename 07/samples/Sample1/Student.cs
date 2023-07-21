namespace Sample1;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public void Print()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}