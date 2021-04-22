using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11
{
    class Parent
    {

        public virtual void Method1() 
        {
            Console.WriteLine("Parent Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Parent Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Parent Method3");
        }
    }
}
