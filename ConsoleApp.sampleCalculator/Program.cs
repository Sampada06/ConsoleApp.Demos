// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Welcome to Sample Calculator!!!");


//show calculator options
int choice = 0;
int num1, num2 = 0;

while(choice != -1)
{
    try
    {
        PrintMenu();

        choice = Convert.ToInt32(Console.ReadLine());
      

        if (choice == -1)
        {
            break;
        }

        Console.Write("Enter the first number : ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number : ");
        num2 = Convert.ToInt32(Console.ReadLine());
     
        //Decide which operation is needed based on selected operation
        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = num1 + num2;
                break;
            case 2:
                answer = num1 - num2;
                break;
            case 3:
                answer = num1 * num2;
                break;
            case 4:
                answer = num1 / num2;
                break;
            case 5:
                for (int i = num1; i <= num2; i++)
                {
                    answer += i;
                }
                break;
            default:
                throw new Exception("Invalid Menu Item Selected."); 
        }
        Console.WriteLine($"The answer is {answer}");
        Console.WriteLine("Press enter to continue!");
        Console.ReadLine();
    }
    catch (DivideByZeroException)
    { 
        Console.WriteLine("Can not divide by zero");
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        continue;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        
    }
    finally
    {
        Console.WriteLine("press any key to try again.");
        Console.ReadLine();
    }
}
Console.WriteLine("Thank you for using sample calculator");

void PrintMenu()
{
    Console.WriteLine("Select an operation (Press -1 to exit) :");
    Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Division \n5.Fibonacci series. ");
}



