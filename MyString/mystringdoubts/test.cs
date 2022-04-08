using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP
{
    public static class Test
    {

        // This method is a test mesthod to check the length and index of the given string
        public static void MyTest()
        {
            // create an empty character array, and inside given some characters 
            char[] a = { 'M', 'y', ' ', 'n', 'a', 'm', 'e' }; 
            MyString s2 = new MyString(a);
            // Calcutation of the index of the specified array
            Console.Write($" MyTest : 1. Should print Index Value 'y': {s2[1]}"); ; Console.WriteLine();

            // Calculation of the Length of the specified array
            Console.Write($" MyTest : 2. Should print Length '7': {s2.Length}"); ; Console.WriteLine();

        }

    }
}
