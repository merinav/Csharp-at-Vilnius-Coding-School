using System;

namespace LearningApp
{
    class Program5
    {
        static void Main()
        {
            //pilnas funkcijos aprasas:
            //<static or not> <access specifier> <return type> <method name> (<parameters>)
            // {<method body>}
            Console.WriteLine("Hello Main");
            //Task1();
            //Task2KMI();
            //Task3Calculator();
            //Task4GuessNumber();
            //Task5Max();
            //Task6InRange();
            //Task7IsPrime();
            //Task8D20();
            //Task9D10();
            //Task10D6();
            //Task11IsNumberBetween();


            //f-jos pavadinimas is didziosios, skirtingai nei kintamieji
            //f-jos pavadinimas - pagal tai ka f-ja daro
            //jei kvieti f-ja be skliaustu, tai kompas mano, kad kintamasis.
            //f-jos parametrai: gali priskirt jiems reiksmes, kurias naudos, jei nieko negaus is 
            //call'ingo
            //jei "void" - f-ja negrazina nieko
            //f-ja gali grazint viena arba 0 duomenu
            //jei f-ja deklaruojama pvz static string arba static int tai aisku kad grazins
            //atitinkamus duomenis
            //jei f-ja yra grazinanti, tai privalo duot (return)
            //return f-jos veikima sustabdo

            ////???????
            ///passbyvalue vs passbyref ---- kaip deliojas atminty
            ///void vs return nesusije su passbyvalue/passbyref
            /// ref / out /  in????
        }


        ///////////////////////////MATH OPERATIONS
        static void Task1()
        {
            Console.WriteLine("Enter number one:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Sum(numberOne, numberTwo);
            Subtraction(numberOne, numberTwo);
            Multiplication(numberOne, numberTwo);
            Division(numberOne, numberTwo);
            Sum();
        }

        static void Sum(int one = 1, int two = 3)
        {
           Console.WriteLine(one + two);
        }
        static void Subtraction(int one = 1, int two = 3)
        {
            Console.WriteLine(one - two);
        }
        static void Multiplication(int one = 1, int two = 3)
        {
            Console.WriteLine(one * two);
        }
        static void Division(int one = 1, int two = 3)
        {
            Console.WriteLine(one / two);
        }

        ///////////////////////////KMI CALCULATOR
        static void Task2KMI()
        {
            Console.WriteLine("Iveskite svori kilogramais:");
            int svoris = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite ugi metrais:");
            double ugis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(GetIsvada(GetKmi(svoris, ugis)));
        }
        static double GetKmi(int svoris, double ugis)
        {
            return  svoris / (ugis * ugis);           
        }
        static string GetIsvada(double paskaiciuotasKmi)
        {
            string isvada = "";
            if (paskaiciuotasKmi < 15)
            {
                isvada = "badaujantis";
            }
            else if (paskaiciuotasKmi < 18.5)
            {
                isvada = "liesas";
            }
            else if (paskaiciuotasKmi < 25)
            {
                isvada = "normalus";
            }
            else if (paskaiciuotasKmi < 30)
            {
                isvada = "virssvoris";
            }
            else if (paskaiciuotasKmi < 40)
            {
                isvada = "nutukes";
            }
            else
            {
                isvada = "ligotai nutukes";
            }
            return isvada;
        }

        
        ///////////////////////////CAlCULATOR DONE
        
        static void Task3Calculator()
        {           
            int no1 = 0;
            int no2 = 0;
            char keyPress;
            do
            {
                Console.WriteLine("Press one of the choices: \n + \n- \n * \n / \n %");
                keyPress = Console.ReadKey(true).KeyChar;

                if (keyPress == '+')
                {
                    Console.WriteLine("Enter two numbers:");
                    no1 = Convert.ToInt32(Console.ReadLine());
                    no2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(no1 + no2);
                }
                else if (keyPress == '-')
                {
                    Console.WriteLine("Enter two numbers:");
                    no1 = Convert.ToInt32(Console.ReadLine());
                    no2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(no1 - no2);
                }
                else if (keyPress == '*')
                {
                    Console.WriteLine("Enter two numbers:");
                    no1 = Convert.ToInt32(Console.ReadLine());
                    no2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(no1 * no2);
                }
                else if (keyPress == '/')
                {
                    Console.WriteLine("Enter two numbers:");
                    no1 = Convert.ToInt32(Console.ReadLine());
                    no2 = Convert.ToInt32(Console.ReadLine());
                    if (no2 != 0)
                    {
                        Console.WriteLine(no1 / no2);
                    } else
                        Console.WriteLine("try again");
                    continue;
                }
                else if (keyPress == '%')
                {
                    Console.WriteLine("Enter two numbers:");
                    no1 = Convert.ToInt32(Console.ReadLine());
                    no2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(no1 % no2);
                }
                else if (keyPress != 'n' && keyPress != '0' && keyPress != (char)27)
                {
                    Console.WriteLine("mistake");
                }

            } while (keyPress != 'n' && keyPress != '0' && keyPress != (char)27);           
            Console.WriteLine("end");                       
        }


        ///////////////////////////GUESS THE NUMBER DONE 
        static void Task4GuessNumber()
        {
            int number = new Random().Next(0, 100);
            Console.WriteLine("Guess the number, enter your guess:");
            int guess = Convert.ToInt32(Console.ReadLine());
            int guessCount = 0;

            bool isAnswerGuessed = true;

            do
            {
                if (guess > number)
                {
                    isAnswerGuessed = false;
                    Console.WriteLine("your guess is bigger, try again:");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guessCount++;
                    continue;
                }
                else if (guess < number)
                {
                    isAnswerGuessed = false;
                    Console.WriteLine("your guess is smaller, try again:");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guessCount++;
                    continue;
                } else
                {
                    isAnswerGuessed = true;
                    break;
                }
            } while (!isAnswerGuessed);
            guessCount++;
            Console.WriteLine("Your guess is correct, you have tried {0} times.", guessCount);
            

        }

        ///////////////////////////FUNCTION MAX
        static void Task5Max()
        //gauna tris sk grazina didziausia
        {
            Console.WriteLine("Enter three numbers:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Biggest number is " + Max(n1, n2, n3)); 
        }

        static int Max(int no1, int no2, int no3)
        {
            int answer;
            if (no1 > no2 && no1 > no3)
            {
                answer = no1;
            }
            else if (no2 > no1 && no2 > no3)
            {
                answer = no2;
            }
            else
            {
                answer = no3;
            }
            return answer;
        }

        ///////////////////////////FUNCTION InRange
        static void Task6InRange()       
        {
            Console.WriteLine("Enter three numbers:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("The first one is between second and third? " + InRange(n1, n2, n3));
        }

        static bool InRange(int no1, int no2, int no3)
        {
            bool answer = true;
            if (no1 > no2 && no1 < no3)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

        ///////////////////////////FUNCTION IsPrime
        static void Task7IsPrime()
        {
            Console.WriteLine("Enter number:");
            int n1 = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("The number is primal: true/false? " + IsPrime(n1));
        }

        static bool IsPrime(int no)
        {
            bool answer = true;
            if (no > 1)
            {
                for (int i = 2; i < no; i++)
                {
                    int remainder;
                    remainder = no % i;
                    if (remainder == 0)
                    {
                        answer = false;
                        break;                        
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return answer;
        }

        ///////////////////////////FUNCTION Random D20
        static void Task8D20()
        {
            int number = new Random().Next(1, 20);
            Console.WriteLine(number);

        }

        ///////////////////////////FUNCTION Random D10
        static void Task9D10()
        {
            int number = new Random().Next(1, 10);
            Console.WriteLine(number);

        }

        ///////////////////////////FUNCTION Random D6
        static void Task10D6()
        {
            int number = new Random().Next(1, 6);
            Console.WriteLine(number);

        }

        ///////////////////////////FUNCTION NUMBER INBETWEEN
        static void Task11IsNumberBetween()
        {
            int valueFrom = GetValueFrom();
            int valueTo = GetValueTo();
            int number = GetNumber();
            GetResult(CheckIfInRange(valueFrom, valueTo, number), number);
        }

        static int GetValueFrom()
        {
            Console.WriteLine("Enter from:");
            int valueFrom = Convert.ToInt32(Console.ReadLine());
            return valueFrom;
        }

        static int GetValueTo()
        {
            Console.WriteLine("Enter to:");
            int valueTo = Convert.ToInt32(Console.ReadLine());
            return valueTo;
        }
        static int GetNumber()
        {
            Console.WriteLine("Enter number for checking:");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static bool CheckIfInRange(int valueFrom, int valueTo, int number)
        {
            bool answer = true;
            if (number > valueFrom && number < valueTo)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
            return answer;
        }

        static void GetResult(bool answer, int number)
        {
            if (answer == true)
            {
                Console.WriteLine("correct! " + number);
            }
            else
            {
                Console.WriteLine("Incorrect, try again.");
                Task11IsNumberBetween();
            }
        }

        ///////////////////////////FIBERNATI
        static void Task12Fibonacci()
        {
           

        }








    }
}
