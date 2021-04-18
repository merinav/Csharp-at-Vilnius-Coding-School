using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningApp
{
    class Program7
    {
        static void Main()
        {
            //TaskRandomNumbers();
            TaskRandomTextOnline();
        }

        static void Lesson()
        {   
            //bandymai per pamoka:
            int number = 234;
            int[] numbers = { 1, 22, 333, 444 };

            List<int> numberList = new List<int>();
            List<int> numberList2 = new List<int>() { 121, 222, 33434, 44546 };

            //gali buti list'as masyvu, list'as list'u, list'as beleko.

            List<string> texts = new List<string>() { "first", "second", "third", "fourth" };
            texts.Add("fith");
            texts.Insert(0, "zero");
            List<string> listToAdd = new List<string>() { "1", "2", "3" };
            texts.AddRange(listToAdd);
            string[] arrayToAdd = new string[] { "**one", "**two", "**three" };
            texts.AddRange(arrayToAdd);
            texts.InsertRange(1, arrayToAdd);
            texts.RemoveAll(FindAll);

            foreach (string item in texts)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

            PrintListOfStrings(texts);
        }

        static bool FindAll(string element)
        {
            if (element == "**two")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintListOfStrings(List<string> list)
        {
            foreach (string item in list)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }

        static void PrintListOfInts(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }

        static void ListOperations()
        {
            List<int> numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintListOfInts(numberList);
            Console.WriteLine("count of list elements is " + numberList.Count);
            Console.WriteLine("does list contain zero: " + numberList.Contains(0));
            Console.WriteLine("index of number 6 is " + numberList.IndexOf(6));
            Console.WriteLine("first even number: " + numberList.Find(IsEven));
            //Console.WriteLine("all even numbers: " + numberList.FindAll(IsEven));
            Console.WriteLine("are there even numbers: " + numberList.Exists(IsEven));
            Console.WriteLine("are all numbers even: " + numberList.TrueForAll(IsEven));

            numberList.Remove(1);
            PrintListOfInts(numberList);
            numberList.RemoveAt(0);
            PrintListOfInts(numberList);

            numberList.Sum();
            Console.WriteLine(numberList.Sum());
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void TaskRandomNumbers()
        {                        
            List<int> numberList = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int number = rnd.Next(1, 100);
                numberList.Add(number);
            }
            Console.WriteLine("All 100 random numbers:");
            PrintListOfInts(numberList); 
            Console.WriteLine();
            RemoveItemsOver80(numberList);
            Console.WriteLine("Random numbers with those over 80 removed:");
            PrintListOfInts(numberList);
            Console.WriteLine();
            Console.WriteLine("Even numbers from remaining list:");
            foreach (int item in numberList)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Count of numbers on the list:" + numberList.Count);
            Console.WriteLine();
            Console.WriteLine("All numbers less than 20: ");
            PrintListOfInts(numberList.FindAll(IsLessThan20));           
        }

        static void RemoveItemsOver80(List<int> numberList)
        {
            foreach (int item in numberList.ToList())
            {
                if (item > 80)
                {
                    numberList.Remove(item);
                }
            }
        }

        static bool IsLessThan20(int number)
        {            
              if (number < 20)
                {
                    return true;
                }
              else
              {
                    return false;
              }
        }

        static void TaskRandomTextOnline() 
        {

            string textString = GetText();
            
            Console.WriteLine("Original text:");
            Console.WriteLine(textString);
            Console.WriteLine();
            
            char[] delimiterChars = { ' ', ',', '.', ':', ';', '!', '?', '\'', '"',
                '\t', '\n', '\r' };
            string[] words = textString.Split(delimiterChars);
            
            Console.WriteLine($"Original text: {words.Length} words or symbols.");
            Console.WriteLine();

            List<string> stringList = new List<string>();
            stringList = words.ToList();

            emptyStringsRemoved(stringList);

            Console.WriteLine($"Text with only words remaining: {stringList.Count} words.");
            Console.WriteLine();
            Console.WriteLine("Remaining text:");
            PrintList(stringList);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            stringList.Sort((y, x) => x.Length - y.Length);
            PrintList(stringList);
            Console.WriteLine();
            Console.WriteLine($"There is word 'split' somewhere: {stringList.Exists(wordSplit)}"); 


        }

        static string GetText()
        {
            return @"The physical nature of time is addressed by general relativity 
            with respect to events in space-time. Examples of events are the collision 
            of two particles, the explosion of a supernova, or the arrival of a rocket 
            ship. Every event can be assigned four numbers representing its time and 
            position (the event's coordinates). However, the numerical values are different
            for different observers. In general relativity, the question of what time it is 
            now only has meaning relative to a particular observer. Distance and time are 
            intimately related and the time required for light to travel a specific distance
            is the same for all observers, as first publicly demonstrated by Michelson and 
            Morley. General relativity does not address the nature of time for extremely 
            small intervals where quantum mechanics holds. At this time, there is no 
            generally accepted theory of quantum general relativity.";
        }

        static void PrintList (List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine($"<{item}>");
            }
        }

        static void emptyStringsRemoved(List<string> textList)
        {
            foreach (string item in textList.ToList())
            {
                if (item == "")                
                {
                    textList.Remove(item);
                }              
            }
        }

        static bool wordSplit(string word) 
        {
            if (word == "split")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
