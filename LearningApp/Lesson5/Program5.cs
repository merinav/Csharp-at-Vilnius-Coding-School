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
            Task2();

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

        static void Task2()
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



    }
}
