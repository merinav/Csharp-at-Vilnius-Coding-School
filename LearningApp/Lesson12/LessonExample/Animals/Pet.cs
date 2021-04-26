using LearningApp.Lesson12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.Animals
{
    class Pet : Animal, IMovable, IRenderable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Move()
        {
            Console.WriteLine("pet move");
        }

        public void Render()
        {
            Console.WriteLine("pet render");
        }

        

    }
}
