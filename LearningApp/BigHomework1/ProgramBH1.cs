using System;

namespace LearningApp
{
    class ProgramBH1
    {
        static void Main(string[] args)
        {
            //Begin9To9();
            Begin99To99();
           
        }


        //su rankiniu switch
        //jei ivestas pvz 06, laikyas kad ok ir duos "sesi"

        static void Begin9To9()
        {
            string input = GetInput9To9();
            if (CheckIfNumber9To9(input, CheckIfNumberIsNegative9To9(input)))
            {
                int inputNumber = ConverStringToInt9To9(input);
                if (CheckIfBetweenParameters9To9(inputNumber))
                {                    
                    Console.WriteLine("Skaicius zodziais:" + " " +ConvertToText9To9(inputNumber) + ".");
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

        static string GetInput9To9()
        {
            Console.WriteLine("Iveskite skaiciu nuo -9 iki 9:");
            return Console.ReadLine();
        }

        static bool CheckIfNumberIsNegative9To9(string input)
        {
            bool isNumberNegative;
            char a = input[0];
            isNumberNegative = a.Equals('-');
            return isNumberNegative;
        }

        static bool CheckIfNumber9To9(string input, bool isNumberNegative)
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

        static int ConverStringToInt9To9(string input)
        {
            int inputNumber = Convert.ToInt32(input);
            return inputNumber;
        }

        static bool CheckIfBetweenParameters9To9(int inputNumber)
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

        static string ConvertToText9To9 (int inputNumber)
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

        //////////////-99-99/////////////

        static void Begin99To99()
        {
            string input = GetInputFor99To99();
            if (CheckIfNumber99To99(input, CheckIfNumberIsNegative99To99(input)))
            {
                int inputNumber = ConverStringToInt99To99(input);
                if (CheckIfBetweenParameters99To99(inputNumber))
                {
                    string first = FirstCharToText(ReturnFirstCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnSecondCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnThirdCharOfArray(ConvertIntToCharArray(inputNumber)));
                    string second = SecondCharToText(ReturnFirstCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnSecondCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnThirdCharOfArray(ConvertIntToCharArray(inputNumber)));
                    string third = ThirdCharToText(ReturnFirstCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnSecondCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnThirdCharOfArray(ConvertIntToCharArray(inputNumber)));
                    Console.WriteLine(CompileResultText(first, second, third));

                    
                }
                else
                {
                    Console.WriteLine("Jusu ivestas skaicius nera tarp -99 ir 99.");
                }
            }
            else
            {
                Console.WriteLine("Jus ivedete ne skaiciu.");
            }
        }

        static string GetInputFor99To99()
        {
            Console.WriteLine("Iveskite sveika skaiciu nuo -99 iki 99:");
            return Console.ReadLine();
        }

        static bool CheckIfNumberIsNegative99To99(string input)
        {
            bool isNumberNegative;
            char a = input[0];
            isNumberNegative = a.Equals('-');
            return isNumberNegative;
        }

        static bool CheckIfNumber99To99(string input, bool isNumberNegative)
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

        static int ConverStringToInt99To99(string input)
        {
            int inputNumber = Convert.ToInt32(input);
            return inputNumber;
        }

        static bool CheckIfBetweenParameters99To99(int inputNumber)
        {
            bool betweenParameters;
            if (inputNumber >= -99 && inputNumber <= 99)
            {
                betweenParameters = true;
            }
            else
                betweenParameters = false;
            return betweenParameters;
        }

        static char[] ConvertIntToCharArray(int input) 
        {            
            char[] charArrayNumbersToConvert = new char[3];
            string inputNumber = Convert.ToString(input);
            for (int i = 0; i < inputNumber.Length; i++)
            {
                char a = inputNumber[i];
                charArrayNumbersToConvert[i] = a;
            }
            return charArrayNumbersToConvert;
        }

        static char ReturnFirstCharOfArray(char[] charArrayNumbersToConvert)
        {
            char a;
            if (charArrayNumbersToConvert[0] == '-' ||
                charArrayNumbersToConvert[0] == '0' ||
                charArrayNumbersToConvert[0] == '1' ||
                charArrayNumbersToConvert[0] == '2' ||
                charArrayNumbersToConvert[0] == '3' ||
                charArrayNumbersToConvert[0] == '4' ||
                charArrayNumbersToConvert[0] == '5' ||
                charArrayNumbersToConvert[0] == '6' ||
                charArrayNumbersToConvert[0] == '7' ||
                charArrayNumbersToConvert[0] == '8' ||
                charArrayNumbersToConvert[0] == '9')
            {
                a = charArrayNumbersToConvert[0];
            }
            else
            {
                a = '*';
            }
            return a;
        }

        static char ReturnSecondCharOfArray(char[] charArrayNumbersToConvert)
        {
            char b;
            if (charArrayNumbersToConvert[1] == '0' || 
                charArrayNumbersToConvert[1] == '1' ||
                charArrayNumbersToConvert[1] == '2' ||
                charArrayNumbersToConvert[1] == '3' ||
                charArrayNumbersToConvert[1] == '4' ||
                charArrayNumbersToConvert[1] == '5' || 
                charArrayNumbersToConvert[1] == '6' || 
                charArrayNumbersToConvert[1] == '7' || 
                charArrayNumbersToConvert[1] == '8' || 
                charArrayNumbersToConvert[1] == '9')
            {
                b = charArrayNumbersToConvert[1];
            }
            else
            {
                b = '*';
            }
            return b;
        }

        static char ReturnThirdCharOfArray(char[] charArrayNumbersToConvert)
        {
            char c;
            if (charArrayNumbersToConvert[2] == '0' ||
                charArrayNumbersToConvert[2] == '1' ||
                charArrayNumbersToConvert[2] == '2' ||
                charArrayNumbersToConvert[2] == '3' ||
                charArrayNumbersToConvert[2] == '4' ||
                charArrayNumbersToConvert[2] == '5' ||
                charArrayNumbersToConvert[2] == '6' ||
                charArrayNumbersToConvert[2] == '7' ||
                charArrayNumbersToConvert[2] == '8' ||
                charArrayNumbersToConvert[2] == '9')
            {
                c = charArrayNumbersToConvert[2];
            }
            else
            {
                c = '*';
            }
            return c;
        }

        static string FirstCharToText(char a, char b, char c)
        {
            string first = "";
            if (a != '*' && b != '*' && c !='*')
            {
                first = "Minus ";
            }
            else if (a != '*' && b != '*' && c == '*')
            {
                if (a == '-')
                {
                    first = "Minus ";
                }               
                else if (a == '9')
                {
                    first = "Devyniasdesimt ";
                }
                else if (a == '8')
                {
                    first = "Astuoniasdesimt ";
                }
                else if (a == '7')
                {
                    first = "Septyniasdesimt ";
                }
                else if (a == '6')
                {
                    first = "Sesiasdesimt ";
                }
                else if (a == '5')
                {
                    first = "Penkiasdesimt ";
                }
                else if (a == '4')
                {
                    first = "Keturiasdesimt ";
                }
                else if (a == '3')
                {
                    first = "Trisdesimt ";
                }
                else if (a == '2')
                {
                    first = "Dvidesimt ";
                }                
            }
            else if (a == '0')
            {
                first = "Nulis";
            }
            return first;            
        }

        static string SecondCharToText(char a, char b, char c)
        {
            string second = "";
            if (a != '*' && b != '*' && c != '*')
            {
                if (b == '9')
                {
                    second = "devyniasdesimt ";
                }
                else if (b == '8')
                {
                    second = "astuoniasdesimt ";
                }
                else if (b == '7')
                {
                    second = "septyniasdesimt ";
                }
                else if (b == '6')
                {
                    second = "sesiasdesimt ";
                }
                else if (b == '5')
                {
                    second = "penkiasdesimt ";
                }
                else if (b == '4')
                {
                    second = "keturiasdesimt ";
                }
                else if (b == '3')
                {
                    second = "trisdesimt ";
                }
                else if (b == '2')
                {
                    second = "dvidesimt ";
                }
            }
            else if (a != '*' && b != '*' && c == '*')
            {
                if (b == '9')
                {
                    second = " devyni";
                }
                else if (b == '8')
                {
                    second = " astuoni";
                }
                else if (b == '7')
                {
                    second = " septyni";
                }
                else if (b == '6')
                {
                    second = " sesi";
                }
                else if (b == '5')
                {
                    second = " penki";
                }
                else if (b == '4')
                {
                    second = " keturi";
                }
                else if (b == '3')
                {
                    second = " trys";
                }
                else if (b == '2')
                {
                    second = " du";
                }
                else if (b == '1')
                {
                    second = " vienas";
                }
            }
            return second;
        }

        static string ThirdCharToText(char a, char b, char c)
        {
            string third = "";
            if (a != '*' && b != '*' && c != '*')
            {
                if (c == '9')
                {
                    third = " devyni";
                }
                else if (c == '8')
                {
                    third = " astuoni";
                }
                else if (c == '7')
                {
                    third = " septyni";
                }
                else if (c == '6')
                {
                    third = " sesi";
                }
                else if (c == '5')
                {
                    third = " penki";
                }
                else if (c == '4')
                {
                    third = " keturi";
                }
                else if (c == '3')
                {
                    third = " trys";
                }
                else if (c == '2')
                {
                    third = " du";
                }
                else if (c == '1')
                {
                    third = " vienas";
                }
            }
            
            return third;
        }

        static string CompileResultText(string first, string second, string third)

        {
            string compiledText = first + second + third + ".";
            return compiledText;

        }


    }
}