// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********** DateTime Manipulation ****************");

//Empty DateTIme Object 
DateTime dateTime = new DateTime();

//Create a DateTime from date and time 
var dateOfBirth = new DateTime(1999, 04, 19);
Console.WriteLine($"My DOB is : {dateOfBirth}");

var exactDateAndTimeOfBirth = new DateTime(1999, 04, 19, 05, 15, 00, DateTimeKind.Local); //DateTimeKind is a enum and used to specify the timezone.
Console.WriteLine($"My DOB is : {exactDateAndTimeOfBirth}");

Console.WriteLine($"Day of Week : {dateOfBirth.DayOfWeek}");
Console.WriteLine($"Day of year : {dateOfBirth.DayOfYear}");
Console.WriteLine($"Time of Day : {exactDateAndTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Tick : {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind : {exactDateAndTimeOfBirth.Kind}");

//Create a DateTIme from current timestamp 
DateTime now = DateTime.Now;
Console.WriteLine($"The Time is now : {now}");

//Create a Datetime from a String
Console.WriteLine("What is your DOB(MM/dd/yyyy) : ");
string DOB = Console.ReadLine();

var userDob = DateTime.Parse(DOB);
Console.WriteLine($"Day of Week : {userDob.DayOfWeek}");
Console.WriteLine($"Day of year : {userDob.DayOfYear}");
Console.WriteLine($"Time of Day : {userDob.TimeOfDay}");
Console.WriteLine($"Tick : {userDob.Ticks}");
Console.WriteLine($"Kind : {userDob.Kind}");

//Change Format DateTime
Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("MMM, dd-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob.ToString("dd-MMMM-yyyy")}");
Console.WriteLine($"Formatted Date: {userDob: dddd, MMMM dd, yyyy}");

//Add additional Time
Console.WriteLine("One hour from now is : " + now.AddHours(1));
Console.WriteLine("One day from now is : " + now.AddDays(1));
Console.WriteLine("One day ago from now is : " + now.AddDays(-1));

//DateOnly 

var dateOnly = new DateOnly(1999,04,19);
//var nextDay = new dateOnly.AddDays(1);

Console.WriteLine($"The Date : {dateOnly}");

