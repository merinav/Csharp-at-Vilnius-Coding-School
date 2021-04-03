using System;

namespace LearningApp
{
    class ProgramHW3
    {
        static void Main(string[] args)
        {
            
            //*** TASK1
            Console.WriteLine("TASK1 Multiplication");
            Console.WriteLine("Enter three numbers");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1*number2*number3);
            Console.ReadLine();
           
            
            //*** TASK2
            Console.WriteLine("TASK2 Math operations");
            Console.WriteLine("Enter number one:");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition equal to " + (no1+no2));
            Console.WriteLine("Subtraction equal to " + (no1 - no2));
            Console.WriteLine("Multiplication equal to " + (no1 * no2));
            double division = (double)no1 / no2;
            Console.WriteLine($"Division equal to {division}");
            Console.ReadLine();
            
            
            //*** TASK3
            Console.WriteLine("TASK3 Average");
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

            
            //*** TASK4
            Console.WriteLine("TASK4 F to C");
            Console.WriteLine("Enter temperature in F:");
            int tempF = Convert.ToInt32(Console.ReadLine());
            int tempC = (tempF - 32) * 5 / 9;
            Console.WriteLine($"Temperature {tempF}F is equal to {tempC}C.");
            Console.ReadLine();


            //*** TASK5 - drink choice
            Console.WriteLine("TASK5 Drinks");
            Console.WriteLine("Please choose one of the drinks by entering the number of the drink.\n" +
                " 1: Soda \n 2: Tea \n 3: Cacao \n 4: Coffee \n 5: None \nPlease enter the number:");
            int drinkChoice;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out drinkChoice))
            {
                switch (drinkChoice)
                {
                    case 1:
                        Console.WriteLine("You have chosen soda.");
                        break;
                    case 2:
                        Console.WriteLine("You have chosen tea.");
                        break;
                    case 3:
                        Console.WriteLine("You have chosen cacao.");
                        break;
                    case 4:
                        Console.WriteLine("You have chosen coffee.");
                        break;
                    case 5:
                        Console.WriteLine("You have chosen to not have a drink.");
                        break;
                    default:
                        Console.WriteLine("Please enter number from 1 to 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter number from 1 to 5.");
            }
            Console.ReadLine();
            

            //*** TASK6 - bread
            Console.WriteLine("TASK6 Bakery");
            Console.WriteLine("Enter number of employees:");
            int employees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many loafs of bread one employee makes in one hour:");
            int loafPerEmployeePerHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the production price of single loaf of bread:");
            double singleLoafProductPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the selling price of single loaf of bread:");
            double singleLoafSellPrice = Convert.ToDouble(Console.ReadLine());
            //singleLoafSellPrice = Math.Round(singleLoafSellPrice, 2);
            int loafsPerDay = 8 * employees * loafPerEmployeePerHour;
            double dayProductPrice = (double) (loafsPerDay * singleLoafProductPrice);
            dayProductPrice = Math.Round(dayProductPrice, 2);
            double daySellPrice = (double) (loafsPerDay * singleLoafSellPrice);
            daySellPrice = Math.Round(daySellPrice, 2);
            double dayProfit = (double) (daySellPrice - dayProductPrice);
            dayProfit = Math.Round(dayProfit, 2);
            Console.WriteLine($"The bakery can produce {loafsPerDay} loafs of bread per an 8 hour working day." +
                $"\nBakery produces all the loafs for a total of ${dayProductPrice}." +
                $"\nBakery sells all the loafs for a total of ${daySellPrice}, and receives a profit of ${dayProfit} per day.");
            Console.ReadLine();
           
        }
    }
}
