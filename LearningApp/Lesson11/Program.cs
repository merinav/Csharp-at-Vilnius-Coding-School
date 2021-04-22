using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11
{
    class Program
    {
        static void Main2() 
        {
            Parent parent = new Parent();
            Child child = new Child();

            parent.Method1();
            parent.Method2();
            parent.Method3();

            child.Method1();
            child.Method2();
            child.Method3();

            Parent parent2 = child;

            parent2.Method1();
            parent2.Method2();
            parent2.Method3();

        }
    }
}
