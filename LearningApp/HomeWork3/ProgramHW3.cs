using System;

namespace LearningApp
{
    class ProgramHW3
    {
        static void Main(string[] args)
        {
            /*
            //*** TASK1
            Console.WriteLine("TASK1");
            Console.WriteLine("Enter three numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1*number2*number3);
            Console.ReadLine();
            
            //*** TASK2
            Console.WriteLine("TASK2");
            Console.WriteLine("Enter number one:");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition equal to " + (no1+no2));
            Console.WriteLine("Subtraction equal to " + (no1 - no2));
            Console.WriteLine("Multiplication equal to " + (no1 * no2));
            Console.WriteLine("Division equal to " + (no1 / no2));
            Console.ReadLine();
            

            //*** TASK3
            Console.WriteLine("TASK3");
            Console.WriteLine("Enter number one:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int n2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter number three:");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number four:");
            int n4 = Convert.ToInt32(Console.ReadLine());
            double average = (double)(n1 + n2 + n3 + n4) / 4;
            Console.WriteLine($"An average of numbers {n1}, {n2}, {n3} and {n4} is " + average + ".");
            Console.ReadLine();
            */

            //*** TASK4
            Console.WriteLine("TASK4");
            Console.WriteLine("Enter temperature in F:");
            int tempF = Convert.ToInt32(Console.ReadLine());
            int tempC = (tempF - 32) * 5 / 9;
            Console.WriteLine($"Temperature {tempF}F is equal to {tempC}C.");
            Console.ReadLine();
        }
    }
}
