// See https://aka.ms/new-console-template for more information

//Void Methods - complete a task without returing a value
void PrintName()
{
    //Method code
    Console.WriteLine("Hello World!!");
}
PrintName();

//Value returing methods - returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}
Console.WriteLine(GetFiveYearsAgo());

//methods with parameters - data being passed into a method

void PrintNameWithParams(string name)
{
    Console.WriteLine($"My name is {name}");
}
int GetYearDifferenceWithParms(int year)
{
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}

Console.WriteLine("Enter you name: ");
string name1 = Console.ReadLine();
PrintNameWithParams(name1);

Console.WriteLine("Enter the year : ");
int yearAgo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"This was {GetYearDifferenceWithParms(yearAgo)} years ago");

//methods with optional parameters - parameter is not required ---/ has a default value

int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}

Console.WriteLine("Enter number of years in past or future : ");
int numberOfYears2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The total number of years " + GetFutureOrPastYear());
Console.WriteLine("The total number of years " + GetFutureOrPastYear(numberOfYears2));

//method with nullable parameters

void PrintNameNullableParam(string? name, int? count)
{
    if (string.IsNullOrEmpty(name))    // string ??= "default value" (?? will check if string is null then it will assign default value)
    {
        name = "default name";
    }

    if (!count.HasValue)              // count ??= 1
    {
        count = 1;
    }

    for(int i=0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

PrintNameNullableParam(null, null);
PrintNameNullableParam("sathya", 6);


