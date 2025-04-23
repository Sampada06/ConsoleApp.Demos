// See https://aka.ms/new-console-template for more information

Console.Write("Enter the number of times you want to repeat : ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i=0; i < num; i++)
{
    Console.WriteLine($"Hello World! - {i}");
}
Console.WriteLine("end of loop!!");

//while loop 
int counter = 0;
while(counter < 5)
{
    Console.WriteLine($"This is while loop - {counter}");
    counter++;
}

//take user input and compute sum of it.

int userInput = 0;
int sum = 0;
while (userInput != -1)
{
    Console.Write("Enter the number (Type -1 to exit): ");
    userInput = Convert.ToInt32(Console.ReadLine());

    if(userInput != -1)
    {
        sum += userInput;
    }
   
}
Console.WriteLine($"The total sum = {sum}");

Console.Write("Enter the number of times you want to repeat : ");
int num2 = Convert.ToInt32(Console.ReadLine());
