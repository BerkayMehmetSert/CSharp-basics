using Sample2;

Student student = new Student();
student.FirstName = "John";
student.LastName = "Doe";
student.StudentNumber = 123456;

Console.WriteLine($"{student.FirstName} {student.LastName} ({student.StudentNumber})");
Console.WriteLine();

Teacher teacher = new Teacher();
teacher.FirstName = "Jane";
teacher.LastName = "Doe";
teacher.Phone = "555-1234";

Console.WriteLine($"{teacher.FirstName} {teacher.LastName} ({teacher.Phone})");
