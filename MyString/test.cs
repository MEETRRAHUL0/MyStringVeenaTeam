﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP
{
    public static class Test
    {

        // This method is a test mesthod to check the length and index of the given string Implemented under Mystring class
        public static void MyTest()
        {
            // create character array, with given characters
            char[] a = { 'M', 'y', ' ', 'n', 'a', 'm', 'e' };

            // Calling constructer of MyString
            MyString s2 = new MyString(a);

            // Calling of the index of the specified array
            Console.Write($" MyTest : 1. Should print Index Value 'y': {s2[1]}"); ; Console.WriteLine();

            // Calling the Length property of MyString in specified array
            Console.Write($" MyTest : 2. Should print Length '7': {s2.Length}"); ; Console.WriteLine();

        }

    }
}
