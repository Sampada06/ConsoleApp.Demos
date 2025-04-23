// See https://aka.ms/new-console-template for more information

Console.WriteLine("************************** Arrays *********************");
//Declare fixed size array
int[] grades = new int[5];

//Add values to fixed size array
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

for(int i =0; i < grades.Length; i++)
{
    //Console.WriteLine("Enter Grade: ");
    //grades[i] = Convert.ToInt32(Console.ReadLine());

}

//Print values in fixed size array
Console.WriteLine("The grades that you entered are : ");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

Console.WriteLine("********************************** Lists **********************************");

//Declear a List
List<int> g = new List<int>();

//Add values to list 
//grade.Add(45);
//grade.Add(50);

//Print values in list - foreach
//Console.WriteLine("Printing grades via foreach loop");
//foreach(int j in g)
//{
//    Console.WriteLine(j);
//}


//Project on Arrays 
Console.WriteLine("Please indicate the number of grades to be entered :");
int numberOfgrades = Convert.ToInt32(Console.ReadLine());

int[] grade = new int[numberOfgrades];
string[] student = new string[numberOfgrades];

for(int i = 0;i < numberOfgrades; i++)
{
    Console.Write("Enter Student Name: ");
    student[i] = Console.ReadLine();

    Console.WriteLine("Enter Grade : ");
    grade[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Below are the students and grade details: ");
{
    for (int i=0; i < numberOfgrades; i++)
    {
        Console.WriteLine($"{student[i]} : {grade[i]}");
    }
}
Console.Write("Enter Student Name: ");
string stud = Console.ReadLine();