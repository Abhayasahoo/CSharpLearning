using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApplication
{

    class Program
    {

        static void Main_1(string[] args)
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2017, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
        }
    }

    class StringProg
    {

        static void Main_2(string[] args)
        {
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.ReadKey();
        }
    }

    class StringProg1
    {

        static void Main_3(string[] args)
        {
            string str = "This is test";

            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
            Console.ReadKey();

            string str1 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str1);
            string substr = str1.Substring(23);
            Console.WriteLine(substr);
            Console.ReadKey();

            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

            string str2 = String.Join("\n", starray);
            Console.WriteLine(str2);
            Console.ReadKey();


        }
    }


}

