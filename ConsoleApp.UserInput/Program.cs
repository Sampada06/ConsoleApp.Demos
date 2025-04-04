//Declare variables
String name = ""; //or string.Empty 
int age = 0;
int retirmentAge = 65;

//prompt user for the input
Console.WriteLine("Enter your name : ");
name = Console.ReadLine();

Console.WriteLine("Enter the age : ");
age = Convert.ToInt32(Console.ReadLine());

int workingYearsRemaining = retirmentAge - age;
Console.WriteLine($"Full Name : {name}");
Console.WriteLine($"Age : {age}");
Console.WriteLine($"Working year remaining : {workingYearsRemaining}");
