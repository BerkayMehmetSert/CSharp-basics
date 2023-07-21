using Sample4;

Student student = new Student();

Console.WriteLine($"Student: {student.FirstName} {student.LastName}");

Student student2 = new Student("John", "Doe");

Console.WriteLine($"Student: {student2.FirstName} {student2.LastName}");