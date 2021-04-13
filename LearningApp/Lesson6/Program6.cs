using System;

namespace LearningApp
{
    class Program6
    {
        static void Main6()
        {

            //int number = 5;
            //int[] numbers = new int[100];            
            //string[] data2 = new string[] { "hi", ",", "ne", "+", "..." };
            //string[] data3 = { "hi", ",", "ne", "+", "..." };
            ////                                0     1    2    3     4
            //string[] data = new string[5] { "hi", ",", "ne", "+", "..." };
            //Console.WriteLine(data[3]);
            //data[3] = "naujas";
            //Console.WriteLine(data[3]);
            //Console.WriteLine(data.Length);
            //Console.WriteLine(data[data.Length]);
            //GetData();
            Check();

        }

        static void GetData()
        {
            string[] data = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter text");
                data[i] = Console.ReadLine();
                Console.WriteLine(data[i]);

            }

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);
            }

            Console.ReadLine();

            for (int i = data.Length - 1; i >= 0; i--)
            {
                Console.Write(data[i]);
            }
        }





       
        static void Check()
        {
            string[] data = {"Mano", "batai", "Mano", "buvo", "batai",
            "buvo", "du", "buvo", "du", "."};

            for (int i = 0; i < data.Length; i++)
            {
                string firstElement = data[i];
                for (int j = i + 1; j < data.Length; j++)
                {
                    string secondElement = data[j];
                    if (firstElement == secondElement)
                    {                        
                            data[j] = "!";                            
                    }
                }

                if (data[i] != "!")
                {                    
                Console.Write(data[i] + " ");                                                         
                //Console.Write(data[data.Length - 1]);                                        
                }

            }
            

        }
        //////NEBAIGTA  







    }
}
