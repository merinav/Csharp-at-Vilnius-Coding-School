using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Dog : Pet
    {
        private string name;

        public Dog(string name) 
        {
            this.name = name;
        }

        public override int GetLifeSpan()
        {
            return 3;
        }

        public override void PrintInfo() 
        {
            Console.WriteLine($"Dog name is {name}");
        }
    }
}
