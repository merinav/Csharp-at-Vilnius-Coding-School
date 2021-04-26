using LearningApp.Lesson12.LessonTaskInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12.LessonTaskInterface.Elements
{
    class Dog : IPrintable, IMovable, IRenderable
    {
        private string dogName;
       

        public string DogName { get; set; }
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Dog(string name)
        {
            dogName = name;
        }

        public void Print()
        {
            Console.WriteLine($"Dog name: {dogName}");
        }

        public void Move()
        {            
            X++;
            Y++;
        }

        public void Render()
        {
            throw new NotImplementedException();
        }
    }
}
