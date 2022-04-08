
using System;


namespace CP
{
    public partial class MyString
    {
        private readonly char[] MyCharArry;

        public int Length => this.MyCharArry.Length;

        public char this[int index]
        {
            get
            {
                if (index < 0 || index >= MyCharArry.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return MyCharArry[index];
            }

            set
            {
                if (index < 0 || index >= MyCharArry.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                MyCharArry[index] = value;
            }
        }

        #region Constractor
        public MyString()
        {
            this.MyCharArry = new char[] { };
        }

        public MyString(char[] charArry)
        {
            this.MyCharArry = charArry;
        }

        public MyString(char myChar)
        {
            this.MyCharArry = new char[] { myChar };
        }
        #endregion

        internal string Write()
        {
            var res = MyCharArry.ToStr();

            Console.WriteLine(res);
            return res;
        }

        private int Sum()
        {
            int sum = 0;
            Array.ForEach(MyCharArry, i => sum += i);
            return sum;
        }
    }
}
