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

            int[] intArray1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] intArray2 = new int[] { 6, 5, 4, 3, 2, 1 };

            Console.WriteLine($"intArray1 is:");
            Print(intArray1);

            Console.WriteLine($"intArray2 is:");
            Print(intArray2);

            //Array1ElementToArray2AllElements(4, intArray2);

            Console.WriteLine("ar elementas yra kitame masyve ir tik viena karta");
            Console.WriteLine(Array1ElementToArray2AllElements(5, intArray2));

            Console.WriteLine("ar pozicijos visu skirtingose vietose:");
            Console.WriteLine(RenameME(intArray1, intArray2));

            //Console.WriteLine($"is testArray1 made of " +
            //    $"different eleements: {ArrayElementsDifferent(testArray1)}");        

            //Console.WriteLine($"is testArray2 made of " +
            //    $"different eleements: {ArrayElementsDifferent(testArray2)}");

            //Console.WriteLine($"are testArray1 and testArray2" +
            //   $"made of same elements but all in different places?:" +
            //   $" {ArraysSameElementsDifferentPlaces(testArray1, testArray2)}");




        }

        //SUSITVARKYTI WRITELINE'us naudojamus patikrinimams!
        static void Print(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        static void IntToIntArray(int number = 123456)
        {
            Console.WriteLine($"number: {number}");

            string numberString = Convert.ToString(number);
            Console.WriteLine($"number in string form: {numberString}");

            int[] numberArray = new int[6];

            for (int i = 0; i < numberString.Length; i++)
            {
                char a = numberString[i];
                int b = (int)(char.GetNumericValue(a));
                //int b = Convert.ToInt32(char.GetNumericValue(a));
                numberArray[i] = b;
                Console.WriteLine(numberArray[i]);
            }
            foreach (int item in numberArray)
            {
                Console.WriteLine($"<{item}>");
            }
        }


        static bool ArrayElementsDifferent(int[] intArray)
        {
            bool returnValue = true;
            int test;
            int test2;
            for (int i = 0; i < intArray.Length; i++)
            {
                test = intArray[i];
                for (int j = i + 1; j < intArray.Length; j++)
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

        static bool Array1ElementToArray2AllElements(int array1Element, int[] intArray2)
        {
            bool returnValue = false;
            int array2Element;
            List<int> tempList = new List<int>();

            //array copy to list
            foreach (int item in intArray2)
            {
                tempList.Add(item);
            }

            //for check up
            Console.WriteLine($"atejes elementas: <{array1Element}>");
            Console.WriteLine($"atejes masyvas2:");
            Print(intArray2);

            Console.WriteLine("tempList:");
            foreach (int item in tempList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //loop to check if array1Element is same as only one of array2 elements (true)
            for (int i = 0; i < intArray2.Length; i++)
            {
                array2Element = intArray2[i];
                if (array1Element == array2Element)
                {
                    tempList.RemoveAt(i);
                    for (int j = 0; j < tempList.Count; j++)
                    {
                        
                        array2Element = tempList[j];
                        if (array1Element == array2Element)
                        {
                            returnValue = false;
                            break;
                        }
                        else
                        {
                            returnValue = true;
                        }
                    }
                } continue;
            }
            return returnValue;
        }

        static bool AllArray1ElementsSameAsAllArray2Elements(bool one, bool two, bool three,
            bool four, bool five, bool six)
        {
            bool returnValue;

            if (one && two && three && four && five && six)
            {
                returnValue = true;
            }
            else
            {
                returnValue = false;
            }

            return returnValue;
        }

        //are array1 elements in different places than array2 elements
        static bool RenameME(int[] intArray1, int[] intArray2) 
        {
            bool returnValue = false;
            int array1element;
            int array2element;

            for (int i = 0; i < intArray1.Length; i++)
            {
                array1element = intArray1[i];
                array2element = intArray2[i];
                    if (array1element == array2element)
                    {
                        returnValue = false;
                        break;
                    }
                    else
                    {
                        returnValue = true;
                    }
            }
            return returnValue;
        }

    }
}
