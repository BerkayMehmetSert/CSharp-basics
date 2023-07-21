namespace Sample4;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student()
    {
    }
    
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}