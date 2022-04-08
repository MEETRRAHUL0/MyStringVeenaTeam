
using System;


namespace CP
{
    public partial class MyString
    {
        //private variable for this class,
        //which will get initialised based on the constructor
        private readonly char[] MyCharArry; 

        public int Length => this.MyCharArry.Length; //Returning Length property

        //Creating an 'integer index operartor' for MyString class to return char.
        public char this[int index]
        {
            //Get method
            get
            {
                // Checking the index value and comparing with length
                if (index < 0 || index >= MyCharArry.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return MyCharArry[index];
            }

            // Set method
            set
            {
                // Checknig the index value and comparing with length
                if (index < 0 || index >= MyCharArry.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                MyCharArry[index] = value;
            }
        }

        //Defining an empty or default constructor
        #region Constractor
        public MyString()
        {
            this.MyCharArry = new char[] { };
        }

        //This constructor will accept only arrays(Calling the chararry constructor)
        public MyString(char[] charArry)
        {
            //gets the list and stores the list in MyCharArry variable
            this.MyCharArry = charArry;
        }

        //This constructor will accept only characters
        public MyString(char myChar)
        {
            this.MyCharArry = new char[] { myChar };
        }
        #endregion

        // Write method to read and write the file
        internal string Write()
        {
            // Array storing in to a string format
            var res = MyCharArry.ToStr();
            // Printing the character array string
            Console.Write(res);
            // Returning the value
            return res;
        }

        //This method is used in operator overloading
        private int Sum()
        {
            int sum = 0;
            // Looping using Linq method
            // Loop all the array and sun ASCII value and will return the result
            Array.ForEach(MyCharArry, i => sum += i);
            return sum;
        }
    }
}
