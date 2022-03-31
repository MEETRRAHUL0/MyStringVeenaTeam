
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CP
{
    public partial class MyString
    {
        #region OperatorOverloading
        public static MyString operator + (MyString str1, MyString str2)
        {
            var res = str1.MyCharArry.ConcatMychar(str2.MyCharArry);
            return res;
        }

        public static bool operator > (MyString str1, MyString str2)
        {
            var res = str1.Sum() > str2.Sum();
            return res;

        }
        public static bool operator < (MyString str1, MyString str2)
        {
            var res = str1.Sum() < str2.Sum();
            return res;

        }
        public static bool operator <= (MyString str1, MyString str2)
        {
            var res = str1.Sum() <= str2.Sum();
            return res;

        }
        public static bool operator >= (MyString str1, MyString str2)
        {
            var res = str1.Sum() >= str2.Sum();
            return res;

        }



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
