
using System.Collections.Generic;
using System.Linq;

namespace CP
{
    // This class is part of MyString class
    public partial class MyString
    {

        internal char[] ToCharArray()
        {
            // We have the array value in this variable, so just returning it
            return MyCharArry;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object myString)
        {
            var res = false;
            if (myString is MyString str)
            {
                // Inbuild method to check the equality of a string
                res = MyCharArry.SequenceEqual(str.MyCharArry);
            }

            return res;
        }

        internal MyString ToLower()
        {
            // Looping the array and checking the ASCII value and adding with 32 to make it Lower case
            var res = new MyString(MyCharArry.Select(c => c >= 65 && c <= 90 ? (char)((int)c + 32) : c).ToArray());
            // Returning the value
            return res;
        }

        internal MyString ToUpper()
        {
            // ASCII value of 'a' = 97
            // Looping the array and checking the ASCII value and substracting with 32 to make it Upper case
            var res = new MyString(MyCharArry.Select(c => c >= 97 && c <= 112 ? (char)((int)c - 32) : c).ToArray());
            // Returning the value
            return res;
        }

        internal IEnumerable<char> Reverse()
        {
            // Creating a variable 'i' to get the MyCharArry length (length always starts from 0)
            var ch = new char[MyCharArry.Length];
            var i = MyCharArry.Length-1;

            // foreach loop to check the array data from reverse order
            foreach (var c in MyCharArry)
            {
                ch[i--] = c;
            }
            // Returning the data
            return ch;
        }
    }
}
