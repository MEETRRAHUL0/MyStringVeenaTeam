
using System;


namespace CP
{
    public partial class MyString
    {
        //private variable for this class to store char array,
        //which will get initialised based on the constructor
        private readonly char[] MyCharArry;

        public int Length => this.MyCharArry.Length; //Returning Length property

        //Creating an 'integer indexer' for MyString class to return char index value.
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


        #region Constractor

        //Defining an empty or default constructor
        public MyString()
        {
            // inislizing private variable with Empty char array
            this.MyCharArry = new char[] { };
        }

        //This constructor will accept only char arrays(Calling the chararry constructor)
        public MyString(char[] charArry)
        {
            //gets the char list and stores in Private variable MyCharArry
            this.MyCharArry = charArry;
        }

        //This constructor will accept only characters
        public MyString(char myChar)
        {
            //gets the char and stores in Private variable MyCharArry
            this.MyCharArry = new char[] { myChar };
        }
        #endregion

        // Write method to read private variable and write the data in console
        internal string Write()
        {
            // Array storing in to a string format
            //ToStr() will read the char array and convert in string
            var res = MyCharArry.ToStr();
            // Printing the converted array in string
            Console.Write(res);
            // Returning the string value
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
