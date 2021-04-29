using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Human : LiveObject, IPrintMe
    {
        private string name;

        public Human(string name) {
            this.name = name;
        }

        protected string Name { get;}

        public override int GetLifeSpan() 
        {
            return 1;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Human name is {name}");
        }
    }
}
