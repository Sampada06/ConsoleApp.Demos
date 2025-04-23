// See https://aka.ms/new-console-template for more information
Console.Write("Enter the student's score : ");
int score = Convert.ToInt32(Console.ReadLine());

if (score < 0 || score > 100)
{
    Console.WriteLine("Invalid input, please enter correct score!.");
}
else if(score > 50 && score <=65)
{
    Console.WriteLine("C");
}
else if(score >65 && score <= 75)
{
    Console.WriteLine("B");
}
else if(score > 75 && score <= 85)
{
    Console.WriteLine("B+");
}
else if (score >85 && score <=100)
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine("F");
}

    //using ternery operator

    string resultStatus = score < 50 ? "Fail" : "Pass";
Console.WriteLine($"Result status : {resultStatus}");
Console.WriteLine("Thank you for using this application.");

// Switch statement
Console.WriteLine("****************************************Switch Statement***************************");
Console.WriteLine("Please enter the day of the week : ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Invalid day number entered!!");
        break;
}


