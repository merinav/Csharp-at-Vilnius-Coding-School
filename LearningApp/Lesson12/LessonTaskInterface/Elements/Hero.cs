using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningApp.Lesson12.LessonTaskInterface.Interfaces;

namespace LearningApp.Lesson12.LessonTaskInterface.Elements
{
    class Hero : IPrintable, IMovable, IRenderable, ISpeaks
    {
        private string heroName;

        public string HeroName {get; set;}
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public string Text { get; set; }

        public Hero(string name) {
            heroName = name;
        }

        public void Print()
        {
            Console.WriteLine($"Hero name: {heroName}");
        }

        public void Move()
        {
            X += 2;
            Y += 2;
        }

        public void Render()
        {
            Console.WriteLine("Hero Render");
        }

        public void Speaks()
        {
            Console.WriteLine(Text);
        }

       
    }
}
