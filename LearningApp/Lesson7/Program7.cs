using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningApp
{
    class Program7
    {
        static void Main7()
        {
            //TaskRandomNumbers();
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
            
            
        }

        static string GetText()
        {
            return @"Today’s Doodle, illustrated by Lagos-based guest artist Ohab TBJ, pays tribute to Nigerian musician Oliver de Coque on 
                his 74th birthday. Crowned the “Highlife King of Africa,” he is widely revered as one of the continent's most prolific recording artists.
                Born on this day in 1947 in the small town of Ezinifite in southeastern Nigeria, Oliver Sunday Akanite first took up the guitar at a young 
                age, and as a teenager, studied the traditional Igbo music of the region and Congolese soukous.In 1970, at a performance by the popular Sunny 
                Agaga and his Lucky Star Band, Akanite convinced Sunny to let him stand in as their guitarist; he was hired on the spot, providing a massive 
                boost to his young career.Also a skilled player of the Nigerian board game okwe, Akanite became known as “Oliver de ka Okwe,” which he later 
                adapted into his stage name, Oliver de Coque. 
                De Coque famously infused the modern West African highlife genre with a Congolese - influenced guitar style and the energetic dance elements 
                of Igbo music he grew up with, crafting a unique musical style, which he called Ogene.Beginning with his first solo release in 1976, de Coque’s 
                music only grew in popularity at home and abroad, as he put out album after album featuring his masterful guitar work and fresh take on African
                pop–over 70 throughout his lifetime.
                In 1994, in recognition of his prodigious music achievement, de Coque was awarded an honorary doctorate in music by the University of New Orleans.
                Thank you, Oliver de Coque, for strumming your way into the hearts of listeners around the world!";
        }
    }
}
