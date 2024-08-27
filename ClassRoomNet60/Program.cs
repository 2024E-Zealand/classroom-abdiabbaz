using ClassRoomNet60;



Student student = new Student("Abdi",1,7);
Student student1 = new Student("Isak", 7, 10);
Student student2 = new Student("Malik",14,12);
Student student3 = new Student("Malik", 26, 4);


ClassRoom classRoom = new ClassRoom();
classRoom.Name = "Programming";
classRoom.SemesterStart = new DateTime(2024, 08, 27);
classRoom.Students.Add(student);
classRoom.Students.Add(student1);
classRoom.Students.Add(student2);
classRoom.Students.Add(student3);

Console.WriteLine("================> Section 1 <================");
Console.WriteLine("Information about the classroom:");
Console.WriteLine($"Classroom Name: {classRoom.Name}");
Console.WriteLine($"Semester Start: {classRoom.SemesterStart.ToShortDateString()}");

Console.WriteLine("================> Section 2 <================");
Console.WriteLine("Students in the classroom:");
foreach (var s in classRoom.Students)
{
    Console.WriteLine($"Name: {s.Name}, Birthday: {s.Birthday}, Birthmonth: {s.BirthMonth}");
}

Console.WriteLine("================> Section 3 <================");
Console.WriteLine("Checking the Students birthmonth... ");
Console.WriteLine(student.Season());
Console.WriteLine(student1.Season());
Console.WriteLine("================> Section 4 <================");
classRoom.CountBirthdays();