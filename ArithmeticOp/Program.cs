using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            int x = 20;
            // y variable accessible only in this scope
            
                int y = 10;
                int Sum = x + y;
                #region Increment
                Console.WriteLine("Total is "+ Sum);
             
                Console.WriteLine(++x);
                Console.WriteLine(x--);
                Console.WriteLine(x++);
                
                Console.WriteLine(--x);
                #endregion
                #region arithmeticop
                Console.WriteLine(x + y);
                Console.WriteLine(x - y);
                Console.WriteLine(x * y);
                Console.WriteLine(x / y);
                Console.WriteLine(x % y);
                #endregion
                #region logicalop
                string name1 = "Dhruv"; int weight1 = 140, height1 = 74;
                string name2 = "Keval"; int weight2 = 124, height2 = 78;

                bool isLight = weight1 < weight2, isLightEq = weight1 <= weight2;
                Console.WriteLine("Is " + name1 + " lighter than " + name2 + "? " + isLight);
                Console.WriteLine("Is " + name1 + " lighter or same weight as " + name2 + "? " + isLightEq);
                

                bool isWeighEq = weight1 == weight2, isTallNotEq = height1 != height2;
                Console.WriteLine("Is " + name1 + " same weight as " + name2 + "? " + isWeighEq);
                Console.WriteLine("Is " + name1 + " not as tall as " + name2 + "? " + isTallNotEq);
                Console.WriteLine("So who is heavier?");
                Console.WriteLine("And who is taller?");

                #endregion
                #region Conditionop
                int year = 1993;
                int month = 8;
                int day = 14;
                string date=month==1?"Jan":month==8? "August":"Unknown";
               Console.WriteLine("I was born in "+date);

                #endregion
                Console.ReadKey();
          


            }
           //x and y is not accessible out side the scope

        }
    }
}
