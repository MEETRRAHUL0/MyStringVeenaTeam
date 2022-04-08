using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP
{
    class Program
    {   //BRIEF:
        //You are not to change anything in this Main method.
        //This Main method as you have it here will be used to
        //  test your MyString class.
        //You are to implement MyString class to pass the tests
        //  set out in this Main Method.
        //You are to submit one text file: 'MyString.cs'
        //You are allowed to use Methods in other Methods.
        //You are not allowed to use 'string' class in your implementation of 'MyString' class.
        static void Main(string[] args)
        {// In MyString Class, implement ...

            //Implement: Prepare the MyString class with appropriate properties to
            //  work like an array of characters and to return Length property

            //Implement: Create a Constructor that takes no argument.

            //Note that string class has an integer index operator: string[i] returns
            //  character at integer index i.
            string myString = "Year Of The Cat!";
            Console.WriteLine("1. Should print 'O': {0}", myString[5]); Console.WriteLine();




            //Implement: Create a Constructor that takes array of characters

            //Implement: Create 'integer index operartor' for MyString class to
            //  return char.

            //Implement: Create 'Write()' Method

            MyString s1 = new MyString();
            Console.Write("2. Should print nothing: "); s1.Write(); Console.WriteLine();

            char[] a = { 'M', 'y', ' ', 'n', 'a', 'm', 'e' };
            MyString s2 = new MyString(a);
            Console.Write("3. Should print 'My name': "); s2.Write(); Console.WriteLine();

            //Implement: Create an Operator '+' that concatenates two MyStrings
            //Note: In the course of the module we did not do operators.
            //Note: Operators are a bit of learning you must do on your own.
            MyString s3 = s1 + s2;
            Console.Write("4. Should print 'My name': "); s3.Write(); Console.WriteLine();

            //Implement: Create a Constructor that takes a character
            s3 = s2 + new MyString(' ') + s3;
            Console.Write("5. Should print 'My name My name': "); s3.Write(); Console.WriteLine();

            Console.WriteLine();
            //Note we get this operator for free
            s3 += new MyString(' '); s3 += s2;
            Console.Write("6. Should print 'My name My name My name': "); s3.Write(); Console.WriteLine();
            Console.WriteLine();

            //Implement: Create 'ToCharArray()' Method to convert MyString to char[]
            char[] a2 = s3.ToCharArray();
            Console.WriteLine("7. Should print 'M': {0}", a2[8]);

            //Implement: Create 'ToLower()' Method
            MyString s4 = new MyString(new char[] {'A','B','C'});
            Console.Write("8. Should print 'ABC': "); s4.Write(); Console.WriteLine();
            s4.ToLower();
            Console.Write("9. Should print 'ABC': "); s4.Write();//Note s5 doesn't change
            Console.WriteLine();
            MyString s5 = s4.ToLower();
            Console.Write("10. Should print 'ABC': "); s4.Write(); Console.WriteLine();
            Console.Write("11. Should print 'abc': "); s5.Write(); Console.WriteLine();

            //Implement: Create 'ToUpper()' Method
            Console.Write("12. Should print 'ABC': "); s5.ToUpper().Write(); Console.WriteLine();

            Console.WriteLine();
            //Note that all objects inherit 'Equals()' Method from Object class. Equals()
            //  Method compares object references. 'o1.Equals(o2)' returns True if o1 and
            //  o2 have the same reference, not necessarliy the same value (Disclaimer: Not
            //  true in case of value Types)
            char o1 = 'a'; char o2 = 'a'; //Char is value Type
            Console.WriteLine("13. Should print 'True': {0}", o1.Equals(o2));
            char[] o3 = { 'a' }; char[] o4 = { 'a' }; //Arrays are reference Type
            Console.WriteLine("14. Should print 'False': {0}", o3.Equals(o4));
            string o5 = "a"; string o6 = "a"; //String is reference Type
            //Note that string class implements an override to 'Equals()' Method:
            //  'bool string Equals(string value)'. This Method compares the value
            //  of string object with value of another string object (not the
            //  references). And string calss (A reference Type) behaves like a value type.
            Console.WriteLine("15. Should print 'True': {0}", o5.Equals(o6));
            Console.WriteLine();

            //Implement: Override 'Equals()' Method: This Method compares the value
            //  of MyString object with value of another MyString object, returns True if
            //  they compare.
            Console.WriteLine("16. Should print 'False': {0}", s4.Equals(s5));
            MyString s6 = new MyString(new char[] { 'A', 'B', 'C' });
            Console.WriteLine("17. Should print 'True': {0}", s4.Equals(s6));




            //Implement: Create an Operator '==' that takes two MyString parameters,
            //  compares the value of the two MyString parameters, returns True if
            //  they compare.
            Console.WriteLine("18. Should print 'False': {0}", (s4 == s5));
            Console.WriteLine("19. Should print 'True': {0}", (s4 == s6));

            //Implement: Create an Operator '!=' that takes two MyString parameters,
            //  compares the value of the two MyString parameters, returns True if
            //  they do not compare.
            Console.WriteLine("20. Should print 'True': {0}", (s4 != s5));
            Console.WriteLine("21. Should print 'False': {0}", (s4 != s6));

            //Implement: Create an Operator '<' that takes two MyString parameters,
            //  returns True if left operand is alphabetically less than the right
            //  operand. 'Less' is measured using ASCII value for characters.
            MyString s7 = new MyString(new char[] { 'a', 'g', 'd' });
            MyString s8 = new MyString(new char[] { 'b', 'a', 'b', 'c' });
            MyString s9 = new MyString(new char[] { 'a', 'b' });
            Console.WriteLine("22. Should print 'True': {0}", (s7 < s8));
            Console.WriteLine("23. Should print 'False': {0}", (s8 < s9));
            Console.WriteLine("24. Should print 'True': {0}", (s9 < s7));

            //Implement: Create an Operator '>' that takes two MyString parameters,
            //  returns True if left operand is alphabetically greater than the right
            //  operand. 'Greater' is measured using ASCII value for characters.
            Console.WriteLine("25. Should print 'True': {0}", (s8 > s7));
            Console.WriteLine("26. Should print 'False': {0}", (s9 > s8));

            //Implement: Create an Operator '<=' that takes two MyString parameters,
            //  returns True if left operand is alphabetically less than or equal to the right
            //  operand.
            MyString s10 = new MyString(new char[] { 'a', 'b' });
            Console.WriteLine("27. Should print 'True': {0}", (s9 <= s7));
            Console.WriteLine("28. Should print 'True': {0}", (s9 <= s10));
            Console.WriteLine("29. Should print 'False': {0}", (s8 <= s9));

            //Implement: Create an Operator '>=' that takes two MyString parameters,
            //  returns True if left operand is alphabetically greater than or equal to the right
            //  operand.
            Console.WriteLine("30. Should print 'True': {0}", (s7 >= s9));
            Console.WriteLine("31. Should print 'True': {0}", (s9 >= s10));
            Console.WriteLine("32. Should print 'False': {0}", (s9 >= s8));

            //Note that string class has a reverse Method that retuns IEnumerable of char
            //  in reverse order of characters
            string str = "ABCDE"; IEnumerable<char> l1 = str.Reverse(); string r1 = "";
            foreach (var item in l1) r1 += item;
            Console.WriteLine("33. Should print 'EDCBA': {0}", r1);

            //Implement: Create the 'Reverse()' Method for MyString class
            MyString s15 = new MyString(new char[] { 'A', 'B', 'C', 'a', 'b', 'c' });
            IEnumerable<char> l2 = s15.Reverse();
            MyString r2 = new MyString(l2.ToArray<char>());
            Console.Write("34. Should print 'cbaCBA': "); r2.Write();

            Test.MyTest();
            Console.ReadLine();
        }
    }
}
