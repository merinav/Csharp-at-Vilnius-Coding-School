﻿using System;

namespace LearningApp
{
    class Program4
    {
        static void Main(string[] args)
        {
            //CIKLAI
            //FOR: kai suskaiciuojamas/zinomas kartojimu skaicius. 
            //static void vs public void?
            //for cikle uzvadinant pradine operacija naudojam viena raide indeksui
            //is eiles (i, j, k, m, n). LOKALUS KINTAMASIS
           
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
           */

            //uzduotys FOR ciklui
            
            /*Console.WriteLine("task1");
            for (int i = 0; i <= 20; i+=3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            Console.WriteLine("task2");
            Console.WriteLine("Enter low limit:");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter high limit:");
            int no2 = Convert.ToInt32(Console.ReadLine());
            if (no1 > no2)
            {
                Console.WriteLine("bad limits");
            }
            else
            {   
            for (int i = no1; i <= no2; i++)
                {
                    Console.WriteLine($"{i}  {i*i}");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
            */

            /*
            Console.WriteLine("task3");
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum = {0}", sum);
            
            //variantas su ($"Sum = {sum}, sum) ???

            //ciklas WHILE. naudojam kai nezinom pradzios ir pabaigos
            
            int nr = 0;
            while (nr < 10)
            {
                Console.WriteLine(nr);
                nr++;
            }
            */


            //task4
            /*
            Console.WriteLine("task4");
            Console.WriteLine("Choose from three drinks by entering their number: \n 1 Coffee \n 2 Tea \n 3 Water");
            int input = Convert.ToInt32(Console.ReadLine());
        
                while (input > 3)
                {
                    Console.WriteLine("bad input, try again:");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                switch (input)
                {
                    case 1:
                        Console.WriteLine("you chose 1");
                        break;
                    case 2:
                        Console.WriteLine("you chose 2");
                        break;
                    default:
                        Console.WriteLine("you chose 3");
                        break;
                }
            

            Console.WriteLine("task4 - kitu budu");
            Console.WriteLine("Choose from three drinks by entering their number: \n 1 Coffee \n 2 Tea \n 3 Water");

            int input1;
            do
            {
                Console.WriteLine("input:");
                input1 = Convert.ToInt32(Console.ReadLine());

            } while (input1 > 3);
            
            
            //!!!nebaigta!!!!
            */

            //task lektuvas
            //Console.WriteLine("task plane");
            /*
            const int planeSeats = 8;
            const int planeSeatsWindow = 4;
            const string yesAnswer = "yes";
            const string noAnswer = "no";
            int allSeatsTaken = 0;
            int windowSeatsTaken = 0;
            string input;

            while (windowSeatsTaken < planeSeatsWindow && allSeatsTaken < planeSeats)
            {
                do
                {
                    Console.WriteLine("Enter whether you wish to sit by the window (yes/no):");
                    input = Console.ReadLine();
                }
                while (input != yesAnswer && input != noAnswer);

                if (input == yesAnswer)
                {
                    windowSeatsTaken++;
                    allSeatsTaken++;
                }
                    allSeatsTaken++;
                }
            */


            //paskutiniai uzdaviniai
            /*
            int sum = 0;
            Console.WriteLine(sum);
            int i = 0;
            for (; ; )  
            {

                if (i % 5 == 0)
                {
                    i++;
                    continue; }

                if (i > 123)
                { break; } 
                    
                
                sum += i;
                i++;
            }
              Console.WriteLine("Sum = {0}", sum);
            */

        }
    }
}
