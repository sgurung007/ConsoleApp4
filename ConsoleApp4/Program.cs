using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            Console.WriteLine("my animal int {0}, " +
                "double {1}, char {2}, bool {3}",animal1.MyInt,
                animal1.MyDouble,animal1.MyChar, animal1.MyBool);


            int myIntFromDobule = (int)animal1.MyDouble;
            Console.WriteLine("my integer from double is: ",myIntFromDobule);

            //console.writeline("enter you name: ");
            //string namestring = console.readline();
            //console.writeline("welcome {0}.", namestring);

            int myInt = 10;
            myInt++;
            Console.WriteLine(myInt);

            Console.WriteLine(Math.Max(20,10));
          
        }
    }
}


/*These are my notes 
 * Built in methods for converstion
 * Convert.ToBoolean
 * Convert.ToDobule
 * Convert.ToString
 * Convert.ToInt32(int)
 * Convert.ToInt64(long)
 * 
 * + addition
 * - subtraction
 * * multiplication
 / division
    % modulus
    ++ increment
    -- decrement

 * 
 */
