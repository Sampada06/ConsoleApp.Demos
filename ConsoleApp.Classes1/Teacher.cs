﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Classes1
{
    public class Teacher : Person 
    {
        public void GenerateTeacherIdNumber()
        {
            _idNumber = "TCH-" + GetRandomNumber();
        }
    }
}
