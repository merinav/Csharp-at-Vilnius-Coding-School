using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningApp.Lesson12.LessonTaskInterface.Interfaces;

namespace LearningApp.Lesson12.LessonTaskInterface.Elements
{
    class Ghost : IPrintable, IMovable, IRenderable
    {
        private int ghostAge;
        private string ghostName;


        public int GhostAge { get; set; }
        public string GhostName { get; set; }
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Ghost(int age, string name)
        {
            ghostAge = age;
            ghostName = name;
        }

        public void Print()
        {
            Console.WriteLine($"Ghost named {ghostName} is {ghostAge} years old.");
        }

        public void Move()
        {           
            X += 5;
            Y += 5;
        }

        public void Render()
        {
            Console.WriteLine("Ghost Render");
        }
    }
}
