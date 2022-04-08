
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CP
{
    // This class is part of MyString class
    public partial class MyString
    {

        #region OperatorOverloading

        // This method is to concatinating two strings
        public static MyString operator + (MyString str1, MyString str2)
        {
            // ConcatMychar is defined in the Extensions.cs file
            var res = str1.MyCharArry.ConcatMychar(str2.MyCharArry);
            return res;
        }

        // This method will check the greater string
        // Getting the ASCII value of each array and compare
        public static bool operator > (MyString str1, MyString str2)
        {
            //If the ASCII value is greater then prints it
            var res = str1.Sum() > str2.Sum();
            return res;

        }

        // This method will check the lesser string
        // Getting the ASCII value of each array and compare
        public static bool operator < (MyString str1, MyString str2)
        {
            //If the ASCII value is greater then prints it
            var res = str1.Sum() < str2.Sum();
            return res;

        }

        // This method will check the string is lesser or equals
        // Getting the ASCII value of each array and compare
        public static bool operator <= (MyString str1, MyString str2)
        {
            //If the ASCII value is greater than or equals to, then prints it
            var res = str1.Sum() <= str2.Sum();
            return res;

        }

        // This method will check the string is greater or equals
        // Getting the ASCII value of each array and compare
        public static bool operator >= (MyString str1, MyString str2)
        {
            //If the ASCII value is greater than or equals to, then prints it
            var res = str1.Sum() >= str2.Sum();
            return res;

        }


        // This method will check the 2 char array is queal
        public static bool operator ==(MyString str1, MyString str2)
        {
            // Getting the ASCII value of each array and compare
            // Responce variable, default is true
            var res = true;

            // looping first array and reading each char
            foreach (var c in str1.MyCharArry)
            {
                // checking wether char array 2 does not contain the char present in c variable
                if (!str2.MyCharArry.Contains(c))
                {
                    // if its not contain , then we know, both the array in not equal and break the Loop ,
                    res = false;
                    break;
                }
            }
            return res;

        }

        // This method will check the 2 strings equal or not
        // Getting the ASCII value of each array and compare
        public static bool operator !=(MyString str1, MyString str2)
        {
            // Responce variable, default is false
            var res = false;

            // looping first array and reading each char
            foreach (var c in str1.MyCharArry)
            {
                // checking wether char array 2 does not contain the char present in c variable
                if (!str2.MyCharArry.Contains(c))
                {
                    // if its not contain , then we know, both the array in not equal and break the Loop ,
                    res = true;
                    break;
                }
            }
            return res;
        }
        #endregion

    }
}
