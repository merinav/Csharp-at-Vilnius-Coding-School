using System;

namespace LearningApp
{
    class ProgramBH1
    {
        static void MainBH1(string[] args)
        {
            //Begin9To9();
            //Begin19To19();
            //Begin99To99();

        }       

        //neispresti klausimai:
        //jei ivestis tarkim 02, uzskaitys kaip 2, blogai kai ima duomenis is masyvo
        //19-19 ir 99-99 ivestis tarkim "k8", luzta ties converstringtoint
        //nors turetu luzt ties checkifnumberXtoX
        //bet neluzta jei ivestis "8k"
        //kzkas ne taip su checkifnumberf-ja

        //////////////-9 to 9/////////////
        static void Begin9To9()
        {
            string input = GetInput9To9();
            if (CheckIfNumber9To9(input, CheckIfNumberIsNegative9To9(input)))
            {
                int inputNumber = ConverStringToInt9To9(input);
                if (CheckIfBetweenParameters9To9(inputNumber))
                {                    
                    Console.WriteLine("Skaičius žodžiais:" + " " +ConvertToText9To9(inputNumber) + ".");
                }
                else
                {
                    Console.WriteLine("Jūsų įvestas skaičius nėra tarp -9 ir 9.");
                }
            }
            else
            {
                Console.WriteLine("Jūs ivedėte ne skaičių.");
            }
        }
        
        static string GetInput9To9()
        {
            Console.WriteLine("Iveskite sveiką skaičių nuo -9 iki 9:");
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
                    numberInText = "aštuoni";
                    break;
                case 7:
                    numberInText = "septyni";
                    break;
                case 6:
                    numberInText = "šeši";
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
                    numberInText = "minus penki";
                    break;
                case -6:
                    numberInText = "minus šeši";
                    break;
                case -7:
                    numberInText = "minus septyni";
                    break;
                case -8:
                    numberInText = "minus aštuoni";
                    break;
                case -9:
                    numberInText = "minus devyni";
                    break;
                default: break;           
            }                                         
            return numberInText;
        }

        //////////////-19 to 19/////////////

        static void Begin19To19()
        {
            string input = GetInput19To19();
            if (CheckIfNumber19To19(input, CheckIfNumberIsNegative19To19(input)))
            {
                int inputNumber = ConvertStringToInt19To19(input);
                if (CheckIfBetweenParameters19To19(inputNumber))
                {
                    Console.WriteLine("Skaičius žodžiais:" + " " + ConvertToText19To19(inputNumber) + ".");
                }
                else
                {
                    Console.WriteLine("Jūsų įvestas skaičius nėra tarp -19 ir 19.");
                }
            }
            else
            {
                Console.WriteLine("Jūs ivedėte ne skaičių.");
            }
        }

        static string GetInput19To19()
        {
            Console.WriteLine("Iveskite sveiką skaičių nuo -19 iki 19:");
            return Console.ReadLine();
        }

        static bool CheckIfNumberIsNegative19To19(string input)
        {
            bool isNumberNegative;
            char a = input[0];
            isNumberNegative = a.Equals('-');
            return isNumberNegative;
        }

        static bool CheckIfNumber19To19(string input, bool isNumberNegative)
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

        static int ConvertStringToInt19To19(string input)
        {
            int inputNumber = Convert.ToInt32(input);
            return inputNumber;
        }

        static bool CheckIfBetweenParameters19To19(int inputNumber)
        {
            bool betweenParameters;
            if (inputNumber >= -19 && inputNumber <= 19)
            {
                betweenParameters = true;
            }
            else
                betweenParameters = false;
            return betweenParameters;
        }

        static string ConvertToText19To19(int inputNumber)
        {
            string numberInText = "";
            switch (inputNumber)
            {
                case 19:
                    numberInText = "devyniolika";
                    break;
                case 18:
                    numberInText = "astuoniolika";
                    break;
                case 17:
                    numberInText = "septyniolika";
                    break;
                case 16:
                    numberInText = "sesiolika";
                    break;
                case 15:
                    numberInText = "penkiolika";
                    break;
                case 14:
                    numberInText = "keturiolika";
                    break;
                case 13:
                    numberInText = "trylika";
                    break;
                case 12:
                    numberInText = "dvylika";
                    break;
                case 11:
                    numberInText = "vienuolika";
                    break;
                case 10:
                    numberInText = "dešimt";
                    break;
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
                    numberInText = "minus penki";
                    break;
                case -6:
                    numberInText = "minus šeši";
                    break;
                case -7:
                    numberInText = "minus septyni";
                    break;
                case -8:
                    numberInText = "minus aštuoni";
                    break;
                case -9:
                    numberInText = "minus devyni";
                    break;
                case -10:
                    numberInText = "minus dešimt";
                    break;
                case -11:
                    numberInText = "minus vienuolika";
                    break;
                case -12:
                    numberInText = "minus dvylika";
                    break;
                case -13:
                    numberInText = "minus trylika";
                    break;
                case -14:
                    numberInText = "minus keturiolika";
                    break;
                case -15:
                    numberInText = "minus penkiolika";
                    break;
                case -16:
                    numberInText = "minus šešiolika";
                    break;
                case -17:
                    numberInText = "minus septyniolika";
                    break;
                case -18:
                    numberInText = "minus aštuoniolika";
                    break;
                case -19:
                    numberInText = "minus devyniolika";
                    break;
                default: break;
            }
            return numberInText;
        }

        //////////////-99 to 99/////////////

        static void Begin99To99()
        {
            string input = GetInputFor99To99();
            if (CheckIfNumber99To99(input, CheckIfNumberIsNegative99To99(input)))
            {
                int inputNumber = ConverStringToInt99To99(input);
                if (CheckIfBetweenParameters99To99(inputNumber))                   
                {
                    if ((inputNumber >= 11 && inputNumber <= 19) || (inputNumber >= -19 && inputNumber <= -11))
                    {
                        Console.WriteLine("Skaičius žodžiais:" + " " + ConvertToText11To19(inputNumber) + ".");
                    }
                    else
                    {
                        string first = FirstCharToText(ReturnFirstCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnSecondCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnThirdCharOfArray(ConvertIntToCharArray(inputNumber)));
                        string second = SecondCharToText(ReturnFirstCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnSecondCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnThirdCharOfArray(ConvertIntToCharArray(inputNumber)));
                        string third = ThirdCharToText(ReturnFirstCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnSecondCharOfArray(ConvertIntToCharArray(inputNumber)), ReturnThirdCharOfArray(ConvertIntToCharArray(inputNumber)));
                        Console.WriteLine("Skaičius žodžiais:" + " " + CompileResultText(first, second, third) + ".");
                    }
                }
                else
                {
                    Console.WriteLine("Jūsų įvestas skaičius nėra tarp -99 ir 99.");
                }
            }
            else
            {
                Console.WriteLine("Jūs ivedėte ne skaičių.");
            }
        }

        static string GetInputFor99To99()
        {
            Console.WriteLine("Iveskite sveiką skaičių nuo -99 iki 99:");
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

            //List<char> charList = new List<char>() { };
            //string inputNumber = Convert.ToString(input);
            //for (int i = 0; i < inputNumber.Length; i++)
            //{
            //    char a = inputNumber[i];
            //    charArrayNumbersToConvert[i] = a;
            //}

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
            if (a != '*' && b != '*' && c != '*')
            {
                first = "minus ";
            }
            else if (a != '*' && b != '*' && c == '*')
            {
                if (a == '-')
                {
                    first = "minus ";
                }
                else if (a == '9')
                {
                    first = "devyniasdešimt";
                }
                else if (a == '8')
                {
                    first = "aštuoniasdešimt";
                }
                else if (a == '7')
                {
                    first = "septyniasdešimt";
                }
                else if (a == '6')
                {
                    first = "šešiasdešimt";
                }
                else if (a == '5')
                {
                    first = "penkiasdešimt";
                }
                else if (a == '4')
                {
                    first = "keturiasdešimt";
                }
                else if (a == '3')
                {
                    first = "trisdešimt";
                }
                else if (a == '2')
                {
                    first = "dvidešimt ";
                }
                else if (a == '1')
                {
                    first = "dešimt";
                }

            }
            else if (a != '*' && b == '*' && c == '*')
            {
                if (a == '9')
                {
                    first = " devyni";
                }
                else if (a == '8')
                {
                    first = " aštuoni";
                }
                else if (a == '7')
                {
                    first = " septyni";
                }
                else if (a == '6')
                {
                    first = " šeši";
                }
                else if (a == '5')
                {
                    first = " penki";
                }
                else if (a == '4')
                {
                    first = " keturi";
                }
                else if (a == '3')
                {
                    first = " trys";
                }
                else if (a == '2')
                {
                    first = " du";
                }
                else if (a == '1')
                {
                    first = " vienas";
                }
                else if (a == '0')
                {
                    first = "nulis";
                }
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
                    second = "devyniasdešimt";
                }
                else if (b == '8')
                {
                    second = "aštuoniasdešimt";
                }
                else if (b == '7')
                {
                    second = "septyniasdešimt";
                }
                else if (b == '6')
                {
                    second = "šešiasdešimt";
                }
                else if (b == '5')
                {
                    second = "penkiasdešimt";
                }
                else if (b == '4')
                {
                    second = "keturiasdešimt";
                }
                else if (b == '3')
                {
                    second = "trisdešimt";
                }
                else if (b == '2')
                {
                    second = "dvidešimt";
                }
                else if (b == '1')
                {
                    second = "dešimt";
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
                    second = " aštuoni";
                }
                else if (b == '7')
                {
                    second = " septyni";
                }
                else if (b == '6')
                {
                    second = " šeši";
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
                else if (b == '1')
                {
                    second = "";
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
                    third = " aštuoni";
                }
                else if (c == '7')
                {
                    third = " septyni";
                }
                else if (c == '6')
                {
                    third = " šeši";
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

        static string ConvertToText11To19(int inputNumber) 
        {
            string numberInText = "";
            switch (inputNumber)
            {
                case 19:
                    numberInText = "devyniolika";
                    break;
                case 18:
                    numberInText = "astuoniolika";
                    break;
                case 17:
                    numberInText = "septyniolika";
                    break;
                case 16:
                    numberInText = "sesiolika";
                    break;
                case 15:
                    numberInText = "penkiolika";
                    break;
                case 14:
                    numberInText = "keturiolika";
                    break;
                case 13:
                    numberInText = "trylika";
                    break;
                case 12:
                    numberInText = "dvylika";
                    break;
                case 11:
                    numberInText = "vienuolika";
                    break;               
                case -11:
                    numberInText = "minus vienuolika";
                    break;
                case -12:
                    numberInText = "minus dvylika";
                    break;
                case -13:
                    numberInText = "minus trylika";
                    break;
                case -14:
                    numberInText = "minus keturiolika";
                    break;
                case -15:
                    numberInText = "minus penkiolika";
                    break;
                case -16:
                    numberInText = "minus šešiolika";
                    break;
                case -17:
                    numberInText = "minus septyniolika";
                    break;
                case -18:
                    numberInText = "minus aštuoniolika";
                    break;
                case -19:
                    numberInText = "minus devyniolika";
                    break;
                default: break;
            }
            return numberInText;
        }
        static string CompileResultText(string first, string second, string third)

        {
            string compiledText = first + second + third;
            return compiledText;

        }

        
    }
}