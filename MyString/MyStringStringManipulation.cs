
using System.Collections.Generic;
using System.Linq;

namespace CP
{
    // This class is part of MyString class
    public partial class MyString
    {

        internal char[] ToCharArray()
        {
            // We have the array value in char array variable, so just returning as it is.
            return MyCharArry;
        }

        // if we override the Equal method , then we need to override the GetHashCode() as wll, else
        // will get warning message :
        //Warning CS0659	'MyString' overrides Object.Equals(object o) but does not override Object.GetHashCode() MyStringAssignment
        //Warning CS0661	'MyString' defines operator == or operator != but does not override Object.GetHashCode() MyStringAssignment
        public override int GetHashCode()
        {
            // we dont have any implementation, so we are using Base class implementation
            return base.GetHashCode();
        }

        public override bool Equals(object myString)
        {
            // res varaable with default value of fasle
            var res = false;

            // checking the input object is Mystrint or NOT, if NOT will return false
            if (myString is MyString str)
            {
                // Inbuild method to check the equality of a string
                res = MyCharArry.SequenceEqual(str.MyCharArry);
            }

            // Returning the result
            return res;
        }

        internal MyString ToLower()
        {
            // ASCII value of 'A' = 65 , Z =  90
            // Looping the array and checking the ASCII value and adding with 32 to make it Lower case
            var res = new MyString(MyCharArry.Select(c => c >= 65 && c <= 90 ? (char)((int)c + 32) : c).ToArray());
            // Returning the result in Lower case
            return res;
        }

        internal MyString ToUpper()
        {
            // ASCII value of 'a' = 97 , z =  112
            // Looping the array and checking the ASCII value and substracting with 32 to make it Upper case
            var res = new MyString(MyCharArry.Select(c => c >= 97 && c <= 112 ? (char)((int)c - 32) : c).ToArray());
            // Returning the Result in Upper case
            return res;
        }

        internal IEnumerable<char> Reverse()
        {
            // Empty Array to hold rev Array
            var ch = new char[MyCharArry.Length];
            // Creating a variable 'i' to get the MyCharArry length (length always starts from 0)
            var i = MyCharArry.Length-1;

            // foreach loop on input Array
            foreach (var c in MyCharArry)
            {
                // Storring the input Array in new Array variable in rev order
                ch[i--] = c;
            }
            // Returning the rev Array as a output
            return ch;
        }
    }
}
