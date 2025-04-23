// See https://aka.ms/new-console-template for more information

using ConsoleApp.Classes1;

Person Person; //this will be null by default 

Person baby = new Person();
baby.FirstName = "Sampada";
baby.LastName = "Halli";
baby.DateOfBirth = new DateOnly(2001, 04, 19);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber);

Person p1 = new Person("Sathya", "Saragala", new DateOnly(1998, 06, 11));
p1.PrintFullName();
p1.PrintInitials();

var p2 = new Person("Rohan", "Halli", "435678");
p2.PrintFullName();
p2.PrintInitials();
p2.GenerateTaxNumber();

Teacher teacher = new Teacher();
teacher.FirstName = "Samitha";
teacher.LastName = "Halli";
teacher.DateOfBirth = new DateOnly(2003, 04, 08);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
teacher.GenerateTeacherIdNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine($"{teacherTaxNumber}");
var teacherIdNumber = teacher.GetIdNumber();
Console.WriteLine($"{teacherIdNumber}");

Student student = new();
student.FirstName = "Gouri";
student.LastName = "Patil";
student.DateOfBirth = new DateOnly(2001, 10, 03);

student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
student.GenerateStudentIdNumber();
var studentTaxNumber = student.GetTaxNumber();
Console.WriteLine($"{studentTaxNumber}");
var studentIdNumber = student.GetIdNumber();
Console.WriteLine($"{studentIdNumber}");

// Polygon polygon = new Polygon();      -----Compiler error we can not instatiate abstract class 

Square square = new(10);
var squareArea = square.Area();
Console.WriteLine($"Area of Square is : {squareArea}");

Rectangle rectangle = new(20,10);
var rectangleArea = rectangle.Area();
Console.WriteLine($"Area of Rectangle is : {rectangleArea}");

Triangle tri = new Triangle(5,4);
var triangleArea = tri.Area();
Console.WriteLine($"Area of Triangle is : {triangleArea}");


