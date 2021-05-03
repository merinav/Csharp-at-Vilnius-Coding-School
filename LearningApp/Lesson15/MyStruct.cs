using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson15
{
    struct MyStruct : IPrintData
    {

        public string Name;
        public int Number;
        public List<int> ListOfNumbers;

        public MyStruct(string Name) {
            this.Name = Name;
            Number = 100;
            ListOfNumbers = new List<int>();

        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, number: {Number}");

            foreach (int item in ListOfNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
