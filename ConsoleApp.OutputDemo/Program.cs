// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
Console.WriteLine("I am from India.");
Console.Write("Line1");
Console.Write("Line2\n");

//different data types 
/* string - text 
 * int - integer
 * float - float, decimal,double
 * bool -logical (Ture or False)
 */

String name = "Sampada";
Console.WriteLine("I am " + name);  // String Concatination
Console.WriteLine($"They call me {name}"); //String interpolation
Console.WriteLine("I was given the name {0}",name);  //Formatted String

int age = 24;
Console.WriteLine("My age is : " + age);
