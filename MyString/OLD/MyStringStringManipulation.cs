
using System.Collections.Generic;
using System.Linq;

namespace CP
{
    public partial class MyString
    {

        internal char[] ToCharArray()
        {
            return MyCharArry;
        }

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public override bool Equals(object myString)
        {
            var res = false;
            if (myString is MyString str)
            {
                res = MyCharArry.SequenceEqual(str.MyCharArry);
            }

            return res;
        }

        internal MyString ToLower()
        {
            var res = new MyString(MyCharArry.Select(c => c >= 65 && c <= 90 ? (char)((int)c + 32) : c).ToArray());
            return res;
        }

        internal MyString ToUpper()
        {
            var res = new MyString(MyCharArry.Select(c => c >= 97 && c <= 112 ? (char)((int)c - 32) : c).ToArray());
            return res;
        }

        internal IEnumerable<char> Reverse()
        {
             var ch = new char[MyCharArry.Length];
            var i = MyCharArry.Length-1;

            foreach (var c in MyCharArry)
            {
                ch[i--] = c;
            }

            return ch;
        }
    }
}
