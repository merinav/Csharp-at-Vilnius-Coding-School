using System;

namespace LearningApp
{
    class ProgramBH1
    {
        static void Main(string[] args)
        {
            
            //Sukurti funkciją, kuri ima int skaičių
            //ir grąžina string -skaičių žodžiais
            //PVZ: Vartotojas iveda: “19854” 
            //sukurti funkciją, kuri gali atspausdinti skaičius nuo - 19 … 19 žodžiais
            Begin();
            
        }

        static void Begin()
        {
            string input = GetInput();
            if (CheckIfNumber(input))
            {
                int inputNumber = ConvertStringToInt(input);
                if (CheckIfNumberIsBetweenParameters(inputNumber))
                {
                    Console.WriteLine(ConvertNumberToText(inputNumber));
                }
                else
                {
                    Console.WriteLine("Your number is not between ");
                }
            }
            else
            {
                Console.WriteLine("You did not enter a number");
            }

        }

        static string GetInput()
        {
            Console.WriteLine("Enter any single number from -9 to 9");
            return Console.ReadLine();
        }

        static bool CheckIfNumber(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                bool isInputNumber;
                char a = input[i];
                isInputNumber = Char.IsDigit(a);
                return isInputNumber;
            }
            return false;
            //kaip patikrinti neigiama sk?
            //??? kaip nedaryti dvieju return? 
            //for cikle gali buti ir true ir false, bet kodas verkia, jei nera antro return
        }

        static int ConvertStringToInt(string input)
        {
            int inputNumber = Convert.ToInt32(input);
            return inputNumber;
        }

        static bool CheckIfNumberIsBetweenParameters(int inputNumber)
            //VEIKIA
        {
            bool betweenParameters;
            if (inputNumber >= -9 && inputNumber <= 9)
            {
                betweenParameters = true;
            }
            else
                betweenParameters = false;
            return betweenParameters;
        }

        static string ConvertNumberToText (int inputNumber)
        {
            
            Console.WriteLine(inputNumber + "blabla");
            return "bla";
        }

    }
}