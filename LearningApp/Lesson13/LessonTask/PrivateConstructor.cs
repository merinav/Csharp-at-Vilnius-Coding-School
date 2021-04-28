using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13.LessonTask
{
    class PrivateConstructor
    {
       

        public static PrivateConstructor BuildConstructor() 
        {
            return new PrivateConstructor();
        }

        private PrivateConstructor() 
        {
            
        }

        public void PrintPC() 
        {
            Console.WriteLine("Privateconstructor function");
        }

    }
}
