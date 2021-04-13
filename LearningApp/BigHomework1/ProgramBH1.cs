using System;

namespace LearningApp
{
    class ProgramBH1
    {
        static void Main(string[] args)
        {
            Begin9To9();
        }


        //su rankiniu switch
        //jei ivestas pvz 06, laikyas kad ok ir duos "sesi"

        static void Begin9To9()
        {
            string input = GetInput();
            if (CheckIfNumber(input, CheckIfNumberIsNegative(input)))
            {
                int inputNumber = ConvertStringToInt(input);
                if (CheckIfNumberIsBetweenParameters(inputNumber))
                {                    
                    Console.WriteLine("Skaicius zodziais:" + " " +ConvertNumberToText(inputNumber) + ".");
                }
                else
                {
                    Console.WriteLine("Jusu ivestas skaicius nera tarp -9 ir 9.");
                }
            }
            else
            {
                Console.WriteLine("Jus ivedete ne skaiciu.");
            }
        }

        static string GetInput()
        {
            Console.WriteLine("Iveskite skaiciu nuo -9 iki 9:");
            return Console.ReadLine();
        }

        static bool CheckIfNumberIsNegative(string input)
        {
            bool isNumberNegative;
            char a = input[0];
            isNumberNegative = a.Equals('-');
            return isNumberNegative;
        }

        static bool CheckIfNumber(string input, bool isNumberNegative)
        {
            bool isInputNumber = true;
            if (isNumberNegative)
            {
                for (int i = 1; i < input.Length; i++)
                {                    
                    char a = input[i];
                    isInputNumber = Char.IsDigit(a);
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {                    
                    char a = input[i];
                    isInputNumber = Char.IsDigit(a);                    
                }
            }
            return isInputNumber;
        }

        static int ConvertStringToInt(string input)
        {
            int inputNumber = Convert.ToInt32(input);
            return inputNumber;
        }

        static bool CheckIfNumberIsBetweenParameters(int inputNumber)
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
            string numberInText = "";
            switch (inputNumber)
            {
                case 9:
                    numberInText = "devyni";
                    break;
                case 8:
                    numberInText = "astuoni";
                    break;
                case 7:
                    numberInText = "septyni";
                    break;
                case 6:
                    numberInText = "sesi";
                    break;
                case 5:
                    numberInText = "penki";
                    break;
                case 4:
                    numberInText = "keturi";
                    break;
                case 3:
                    numberInText = "trys";
                    break;
                case 2:
                    numberInText = "du";
                    break;
                case 1:
                    numberInText = "vienas";
                    break;
                case 0:
                    numberInText = "nulis";
                    break;
                case -1:
                    numberInText = "minus vienas";
                    break;
                case -2:
                    numberInText = "minus du";
                    break;
                case -3:
                    numberInText = "minus trys";
                    break;
                case -4:
                    numberInText = "minus keturi";
                    break;
                case -5:
                    numberInText = "minus 5";
                    break;
                case -6:
                    numberInText = "minus sesi";
                    break;
                case -7:
                    numberInText = "minus septyni";
                    break;
                case -8:
                    numberInText = "minus astuoni";
                    break;
                case -9:
                    numberInText = "minus devyni";
                    break;
                default: break;           
            }                                         
            return numberInText;
        }

    }
}