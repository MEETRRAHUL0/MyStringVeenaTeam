using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP
{
    public static class Test
    {


        public static void MyTest()
        {
            char[] a = { 'M', 'y', ' ', 'n', 'a', 'm', 'e' };
            MyString s2 = new MyString(a);
            Console.Write($" MyTest : 1. Should print Index Value 'y': {s2[1]}"); ; Console.WriteLine();


            Console.Write($" MyTest : 1. Should print Lenght '7': {s2.Length}"); ; Console.WriteLine();


        }

    }
}
