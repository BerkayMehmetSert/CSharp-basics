Student student = new Student();
student.FirstName = "John";
student.LastName = "Doe";

Console.WriteLine(student.FirstName + " " + student.LastName);
Console.WriteLine();

var student2 = new Student
{
    FirstName = "Jane",
    LastName = "Doe"
};

Console.WriteLine(student2.FirstName + " " + student2.LastName);
Console.WriteLine();

Student student3 = new()
{
    FirstName = "Sam",
    LastName = "Doe"
};

var students = new Student[3];
students[0] = student;
students[1] = student2;
students[2] = student3;

foreach (Student s in students)
{
    Console.WriteLine(s.FirstName + " " + s.LastName);
}

Console.WriteLine();

student.Print(); // John Doe
student2.Print(); // Jane Doe
student3.Print(); // Sam Doe

class Student
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    // Methods
    public void Print()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}