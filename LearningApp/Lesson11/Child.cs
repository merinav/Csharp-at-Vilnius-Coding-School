using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11
{
    class Child : Parent
    {
        public override void Method1() 
        {
            Console.WriteLine("Child Method1 - override");
        }

        public new void Method2()
        {
            Console.WriteLine("Child Method2 - new");
        }
    }
}
