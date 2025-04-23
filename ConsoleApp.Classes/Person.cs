// See https://aka.ms/new-console-template for more information
//Define a class 
using System.Security.Cryptography;

public class Person
{
    //default constructor 
    public Person()
    {

    }

    public Person(string firstname, string lastname, DateOnly DOB)
    {
        FirstName = firstname;
        LastName = lastname;
        DateOfBirth = DOB;
    }

    public Person(string firstname, string lastname, string taxnumber)
    {
        FirstName = firstname;
        LastName = lastname;
        _taxNumber = taxnumber;
    }

    //define properties / Data Members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    //Field Member 
    private string _taxNumber;
    private string _idNumber;

    //Method 
    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        var FirstInitial = FirstName[0];
        var LastInitial = LastName[0];
        Console.WriteLine($"{FirstInitial} {LastInitial}");
    }

    public void GenerateTaxNumber()
    {
        if (String.IsNullOrEmpty(_taxNumber))
        {
            _taxNumber = RandomNumberGenerator.GetInt32(100000, 9999999).ToString();
        }
        else
        {
            Console.WriteLine("Tax number already exists.");
        }
    }

    public string GetTaxNumber()
    {
        return _taxNumber;
    }

    //Method Overloading (same method names but different parameters)
    public int GetAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

    public int GetAge(int year)
    {
        int age = year - DateOfBirth.Year;
        return age;
    }

    public class Teacher : Person
    {

    }

}



