using System.Security.Cryptography;

namespace ConsoleApp.Classes1
{
    public class Student : Person
    {
        public void GenerateStudentIdNumber()
        {
            _idNumber = "STU-" + GetRandomNumber();
        }
    }
}
