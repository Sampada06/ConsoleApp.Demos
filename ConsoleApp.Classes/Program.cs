// See https://aka.ms/new-console-template for more information
Console.WriteLine("*********************** - Classes and Objects - *******************************!");

Person Person; //this will be null by default 

Person baby = new Person();
baby.FirstName = "Sampada";
baby.LastName = "Halli";
baby.DateOfBirth = new DateOnly(2001, 04, 19);

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();

var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber);

Person p1 = new Person("Sathya", "Saragala", new DateOnly(1998, 06, 11));
p1.PrintFullName();
p1.PrintInitials();

Person p2 = new Person("Rohan", "Halli", "435678");
p2.PrintFullName();
p2.PrintInitials();
p2.GenerateTaxNumber();
