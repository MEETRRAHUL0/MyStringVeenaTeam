

namespace CP
{
    public static class Extensions
    {
        // ToStr method will loop all the array and stores in a single string variable and returns the result 
        public static string ToStr(this char[] myCharArry)
        {
            // New variable called res
            var res = string.Empty;

            // Loop all the array and stores in to a string variable res
            foreach (var c in myCharArry)
            {
                res += c;
            }
            // Returns the result
            return res;
        }

        public static MyString ConcatMychar(this char[] myCharArry1, char[] myCharArry2)
        {
            // Taking the count of both arrays
            var count = myCharArry1.Length + myCharArry2.Length;
            // create an empty array as ch
            var ch = new char[count];
            var i = 0;

            // Looping the first array data to an empty array ch
            foreach (var c in myCharArry1)
            {
                // Adding the array data
                ch[i++] = c;
            }

            // Looping the second array data to the same array ch
            foreach (var c in myCharArry2)
            {
                // Continue adding to the array data
                ch[i++] = c;
            }
            //Store the concatenated array and stores in res variable
            var res = new MyString(ch);
            // Returns res value
            return res;
        }


    }
}
