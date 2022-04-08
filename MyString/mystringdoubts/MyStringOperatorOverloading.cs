
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
        // This method is to concatinating two strings
        #region OperatorOverloading
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


        // This method will check the 2 strings equal or not
        // Getting the ASCII value of each array and compare
        public static bool operator ==(MyString str1, MyString str2)
        {
            var res = true;
            foreach (var c in str1.MyCharArry)
            {
                if (!str2.MyCharArry.Contains(c))
                {
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

            var res = false;
            foreach (var c in str1.MyCharArry)
            {
                if (!str2.MyCharArry.Contains(c))
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
        #endregion

    }
}
