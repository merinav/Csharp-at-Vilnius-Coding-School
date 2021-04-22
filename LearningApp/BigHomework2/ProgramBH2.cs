using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.BigHomework2
{
    class BigHomework2
    {

        
        //Sukurti funkciją, kuri patikrina ar visi masyvo elementai skirtingi.
        //(saugią funkciją, kuri negadina masyvų.)
        //Sukurti funkciją, kuri palygina 2 int[] masyvus,
        //jei jų elementai tokie patys, bet skirtingose vietose - return true, 
        //priešingu atveju – false. 
        //

        static void MainBH2() 
        {

            //IntToIntArray();

            int[] testArray1 = new int[] {1, 2, 3, 4, 5, 6};
            int[] testArray2 = new int[] {6, 5, 4, 3, 2, 1};

            Console.WriteLine($"testArray1 is <{testArray1}>");
            Console.WriteLine($"is testArray1 made of " +
                $"different eleements: {ArrayElementsDifferent(testArray1)}");

            Console.WriteLine($"testArray1 is <{testArray2}>");
            Console.WriteLine($"is testArray2 made of " +
                $"different eleements: {ArrayElementsDifferent(testArray2)}");

            Console.WriteLine($"are testArray1 and testArray2" +
               $"made of same elements but all in different places?:" +
               $" {ArraysSameElementsDifferentPlaces(testArray1, testArray2)}");


            ;

        }

        private static void IntToIntArray(int number = 123456)
        {
            Console.WriteLine($"number: {number}");            
            
            string numberString = Convert.ToString(number);
            Console.WriteLine($"number in string form: {numberString}");

            int[] numberArray = new int[6];

            for (int i = 0; i < numberString.Length; i++)
            {
                char a = numberString[i];
                int b = Convert.ToInt32(char.GetNumericValue(a));
                numberArray[i] = b;
                Console.WriteLine(numberArray[i]);
            }
            foreach (int item in numberArray)
            {
                Console.WriteLine($"<{item}>");
            }
        }

        private static bool ArrayElementsDifferent(int[] intArray) 
        {
            bool returnValue = true;
            int test;
            int test2;           
                for (int i = 0; i < intArray.Length; i++)
                {
                    test = intArray[i];                
                for (int j = i+1; j < intArray.Length; j++)                    
                {
                    test2 = intArray[j];
                    if (test == test2)
                        {
                            returnValue = false;
                        }
                    }               
                }            
            return returnValue;
        }

        private static bool ArraysSameElementsDifferentPlaces(int[] intArray1, int[] intArray2) 
        {
            bool returnValue = true;


            return returnValue;
        }
    }
}
