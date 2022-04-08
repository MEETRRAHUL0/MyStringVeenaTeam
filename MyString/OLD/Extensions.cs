

namespace CP
{
    public static class Extensions
    {
        public static string ToStr(this char[] myCharArry)
        {
            var res = string.Empty;

            foreach (var c in myCharArry)
            {
                res += c;
            }
            return res;
        }

        public static MyString ConcatMychar(this char[] myCharArry1, char[] myCharArry2)
        {
            var count = myCharArry1.Length + myCharArry2.Length;
            var ch = new char[count];
            var i = 0;

            foreach (var c in myCharArry1)
            {
                ch[i++] = c;
            }

            foreach (var c in myCharArry2)
            {
                ch[i++] = c;
            }

            var res = new MyString(ch);
            return res;
        }


    }
}
