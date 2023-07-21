string[] students = { "John", "James", "Sara" };
int[,] points = new int[3, 3];

// John
points[0, 0] = 100;
points[0, 1] = 90;
points[0, 2] = 80;

// James
points[1, 0] = 90;
points[1, 1] = 80;
points[1, 2] = 70;

// Sara
points[2, 0] = 80;
points[2, 1] = 70;
points[2, 2] = 60;

Console.WriteLine($"1st student: {students[0]} points: {points[0, 0]}, {points[0, 1]}, {points[0, 2]}");
