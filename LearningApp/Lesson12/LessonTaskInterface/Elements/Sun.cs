using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningApp.Lesson12.LessonTaskInterface.Interfaces;

namespace LearningApp.Lesson12.LessonTaskInterface.Elements
{
    class Sun : IPrintable, IRenderable, IGlows
    {
        private bool isShining;

        public string IsShining { get; set; }
        public bool Glows { get; set; }

        public Sun(bool shining)
        {
            isShining = shining;
        }

        public void Print()
        {
            if (isShining)
            {
                Console.WriteLine($"Sun is shinning");
            }
            else
            {
                Console.WriteLine($"Sun is not shinning");
            }

            
        }

        public void Render()
        {
            Console.WriteLine("Sun Render");
        }

        public void Glow()
        {
            Console.WriteLine("**************");
            Console.WriteLine("**************");
            Console.WriteLine("**************");
            Console.WriteLine("**************");
            Console.WriteLine("**************");
        }
    }
}
