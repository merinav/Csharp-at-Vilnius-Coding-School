using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson16
{
    class Program16
    {
        static void Main() 
        {
            /*
            string testString = "Mano vardas Meri, man 34";
            char testChar = testString[5];
            char testChar2 = testString[0];
            Console.WriteLine($"<{testChar}>");
            Console.WriteLine($"<{testChar2}>");
            int totalChars = testString.Length;
            string part = testString.Substring(5, 15);
            Console.WriteLine($"<{totalChars}>");
            Console.WriteLine($"<{part}>");
            testString = testString.Remove(5);
            Console.WriteLine($"<{testString}>");
            testString = testString.Replace('M', '!');
            Console.WriteLine($"<{testString}>");
            testString = testString.Insert(5, "yra, nera , taip");
            Console.WriteLine($"<{testString}>");
            string[]  splitted = new string[] { } ;
            splitted = testString.Split(",");
            foreach (string item in splitted)
            {              
                Console.WriteLine($"<{item}>");
            }
            */

            /*
            StringBuilder myString = new StringBuilder("The Heart of Thomas is a 1974 Japanese " +
                "manga series written and illustrated by Moto Hagio (pictured). " +
                "Originally serialized in Shūkan Shōjo Comic, a weekly manga magazine publishing " +
                "shōjo manga – manga aimed at young and adolescent women –" +
                " the series follows the events at a German all-boys school " +
                "after the suicide of student Thomas Werner. \n");

            Console.WriteLine(myString);

            int stringLength = myString.Length;

            Console.WriteLine($"string length: {stringLength}");
            Console.WriteLine();

            Console.WriteLine("Appended string:");
            myString.AppendLine("Appended text bla bla\n");
            Console.WriteLine(myString);

            //myString.AppendFormat();   whut????

            myString.Insert(1, "nenene"); //kiti variantai neaiskus
            Console.WriteLine(myString);

            myString.Replace('a', '!');
            Console.WriteLine(myString);

            myString.Remove(0, 20);
            Console.WriteLine(myString);

            //myString.Clear();
            //Console.WriteLine(myString);

            char[] charArray = new char[5];
            myString.CopyTo(0, charArray, 0, 5);
            Console.WriteLine(charArray);
            */

            File.WriteAllText("myFile.txt", "this is my file content");
            string myFileText = File.ReadAllText("myFile.txt");
            Console.WriteLine(myFileText);

            File.AppendAllText("myFile.txt", " AND THIS IS APPENDED TEXT");

            File.Create("../myFile23214.txt");
        }
    }
}
