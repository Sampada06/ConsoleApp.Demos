// See https://aka.ms/new-console-template for more information

Console.WriteLine("*************** String Manipulation ***********");

//Initialize with a regular string literal.
string s1 = "This is a literal string";
String s2 = "This is a literal string";
Console.WriteLine($"{nameof(s1)} : {s1}");
Console.WriteLine($"{nameof(s2)} : {s2}");

//Declare without initializing.(poosible null exception).
string s3;

//Initialize to null. (possible null exception)
string s4 = null;
Console.WriteLine($"{nameof(s4)} : {s4}");

//Initialize as an empty string.
string s5 = string.Empty;
string s6 = " ";
Console.WriteLine($"{nameof(s5)} : {s5}");
Console.WriteLine($"{nameof(s6)} : {s6}");

//Escape sequences and characters
string sentence = "She said, \"I have your phone\" \r\nThis is next line.";
Console.WriteLine($"{nameof(sentence)} : {sentence}");

//verbatim string literal.
string oldpath = "C:\\program files\\programfolder\\";
string newpath = @"C:\program files\programfolder\";
Console.WriteLine($"{nameof(oldpath)} : {oldpath}");
Console.WriteLine($"{nameof(newpath)} : {newpath}");

//Use a const string to prevent modification to a string
const string path = "C:\\program files\\programfolder\\";
Console.WriteLine($"{nameof(path)} : {path}");

//Raw string literals
string rawLiteral = """ She said, "I have your phone" """;
string rawLiteral1 = """
    She said, "I have your phone"
    This is the next line
    and another one 
    Path = "C:\program files\programfolder\"
    """;
Console.WriteLine($"{nameof(rawLiteral)} : {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)} : {rawLiteral1}");

//Review concatenation and interpolation
s1 = s1 + s2;
s1 += s2;
string newString = $"{s1} {s2} Some random literal text";
string newString1 = s1 + $"{s1} {s2} Some random literal text";
string newString2 = string.Format("Literal string {0} {1}", s1,s2);
Console.WriteLine($"{nameof(newString)} : {newString}");
Console.WriteLine($"{nameof(newString1)} : {newString1}");
Console.WriteLine($"{nameof(newString2)} : {newString2}");

//String manipulation methods and properties

/* Null or empty checks
 * find the length of a string 
 * */

Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
//Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}"); - will throw null exception.

if (!string.IsNullOrEmpty(s4))
{
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
}

if(string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}

//Substrings
string subString = s1.Substring(5);
Console.WriteLine($"{nameof(subString)}: {subString}");
subString = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)}: {subString}");

//Splitting strings
var splitString = s2.Split(' ');
for(int i=0; i <  splitString.Length; i++)
{
    Console.WriteLine(splitString[i]);
}

//Replace 
string replacements1 = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacements1)} : {replacements1}");

string replacements2 = s2.Replace("string", "chicken");
Console.WriteLine($"{nameof(replacements2)}: {replacements2}");


//Convert to string 
string salary = 4556876.02.ToString();
int value = 456788;
string strValue = value.ToString();


//Changing Formatting
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary)+ ": " + value.ToString("C"));  // C represnts the currency here.
