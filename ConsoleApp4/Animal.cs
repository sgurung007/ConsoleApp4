using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Animal
    {
        public int MyInt { get; set; }
        public double MyDouble { get; set; } 
        public char MyChar { get; set; }
        public bool MyBool { get; set; }

        public Animal(int myInt=0, double myDouble=0.00, char myChar='A', bool myBool=true)
        {
            MyInt = myInt;
            MyDouble = myDouble;
            MyChar = myChar;
            MyBool = myBool;
        }
    }
}
