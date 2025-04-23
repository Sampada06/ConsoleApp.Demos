using System.Globalization;

//Declare variables

const int retirmentAge = 65;
String firstName = ""; //or string.Empty 
String lastName = string.Empty;
int age = 0;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender = char.MinValue; //or we can use '\0'
bool working = true; //default is will take false

//prompt user for the input
Console.Write("Enter your first name : ");
firstName = Console.ReadLine();

Console.Write("Enter your last name : ");
lastName = Console.ReadLine();

Console.Write("Enter the DOB (dd/mm/yyyy) : ");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
age = DateTime.Now .Year - dob.Year;

Console.Write("Enter your salary : ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter your gender(M or F) : ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (True or false) : ");
working = Convert.ToBoolean(Console.ReadLine());

int workingYearsRemaining = retirmentAge - age;
var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

Console.WriteLine($"Full Name : {firstName} {lastName}");
Console.WriteLine($"Age : {age}");
Console.WriteLine($"Your salary is : {salary.ToString("C")}");
Console.WriteLine($"Your gender is : {gender}");
Console.WriteLine($"You are Employed : {working}");
Console.WriteLine($"Working year remaining : {workingYearsRemaining}");
Console.WriteLine($"Estimated retirement year : {estimatedRetirementDate.Year}");

    


Console.Write("Enter the age : ");
int age1 = Convert.ToInt32(Console.ReadLine());

