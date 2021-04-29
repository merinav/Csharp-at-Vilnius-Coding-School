using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson14
{
    class Pet : LiveObject, IPrintMe

    {
        
        public override int GetLifeSpan()
        {
            return 2;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Pet life span is");
        }
    }
}
