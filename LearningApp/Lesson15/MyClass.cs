using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson15
{
    class MyClass : IPrintData
    {
        //private string name = "MyClass";
        //private int number = 0;
        //private List<int> listOfNumbers = new List<int> {1, 2, 3};

        public MyClass(string name, int number, List<int> list) 
        {
            this.Name = name;
            this.Number = number;
            this.ListOfNumbers = list;
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public List<int> ListOfNumbers { get; set; }

        
        

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, number: {Number}");

            foreach (int item in ListOfNumbers)
            {
                Console.WriteLine($"list item: {item}");
            }
        }

        public void ChangeInt(int number) {

            Number = number + 1000;
            Print();
        }

        public void EnumFunction(EducationLevel level) 
        {
            switch (level)
            {
                case EducationLevel.Pradinis:
                    Console.WriteLine("Pradinis");
                    break;
                case EducationLevel.Vidurinis:
                    Console.WriteLine("Vidurinis");
                    break;
                case EducationLevel.Aukstasis:
                    Console.WriteLine("Aukstasis");
                    break;
                case EducationLevel.MagistroLaipsnis:
                    Console.WriteLine("MagistroLaipsnis");
                    break;
                case EducationLevel.DaktaroLaipsnis:
                    Console.WriteLine("DaktaroLaipsnis");
                    break;
                default:
                    break;
            }

        }

    }
}
