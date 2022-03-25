using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CP
{
    public class MyString
    {
        private readonly char[] MyCharArry;
        private char myChar;

        #region Constractor
        public MyString()
        {

        }

        public MyString(char[] charArry)
        {
            this.MyCharArry = charArry;
        }

        public MyString(char a)
        {

        }
        #endregion
        internal void Write()
        {
            throw new NotImplementedException();
        }

        #region OperatorOverloading
        public static MyString operator +(MyString str1, MyString str2)
        {
            return (MyString)str1.MyCharArry.Concat(str2.MyCharArry);

            MyString Calc3 = new MyString(new char[] { ' ' });
            Calc3.MyCharArry.Concat(str1.MyCharArry).Concat(str2.MyCharArry);
            return Calc3;

        }

        public static MyString operator >(MyString str1, MyString str2)
        {
            return (MyString)str1.MyCharArry.Concat(str2.MyCharArry);

            MyString Calc3 = new MyString(new char[] { ' ' });
            Calc3.MyCharArry.Concat(str1.MyCharArry).Concat(str2.MyCharArry);
            return Calc3;

        }
        public static MyString operator <(MyString str1, MyString str2)
        {
            return (MyString)str1.MyCharArry.Concat(str2.MyCharArry);

            MyString Calc3 = new MyString(new char[] { ' ' });
            Calc3.MyCharArry.Concat(str1.MyCharArry).Concat(str2.MyCharArry);
            return Calc3;

        }
        public static MyString operator <=(MyString str1, MyString str2)
        {
            return (MyString)str1.MyCharArry.Concat(str2.MyCharArry);

            MyString Calc3 = new MyString(new char[] { ' ' });
            Calc3.MyCharArry.Concat(str1.MyCharArry).Concat(str2.MyCharArry);
            return Calc3;

        }
        public static MyString operator >=(MyString str1, MyString str2)
        {
            return (MyString)str1.MyCharArry.Concat(str2.MyCharArry);

            MyString Calc3 = new MyString(new char[] { ' ' });
            Calc3.MyCharArry.Concat(str1.MyCharArry).Concat(str2.MyCharArry);
            return Calc3;

        }
        #endregion

        #region StringManupulation

        internal char[] ToCharArray()
        {
            throw new NotImplementedException();
        }

        internal MyString ToLower()
        {
            throw new NotImplementedException();
        }

        internal MyString ToUpper()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<char> Reverse()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
