using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson13
{
    class Animal
    {
        private int age;
        private bool alive = true;
        private string name;
        private string species;
        private int x = 0;
        private int y = 0;

        public Animal(int age) 
        {
            this.age = age;
        }

        public Animal(int age, bool alive, string name)
        {
            this.age = age;
            this.alive = alive;
            this.name = name;
        }

        public Animal(string name, string species)
        {
            this.name = name;
            this.species = species;
        }

        public void Move() 
        {
            x++;
            y++;
            Console.WriteLine("Move()");
        }

        public void Move(int number)
        {
            x += number;
            y += number;
            Console.WriteLine("MoveRight()");
        }

        public void Print()
        {
            Console.WriteLine("this is Print()");
        }

        public void Print(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("this is Print(int number)");
            }
            
        }

    }
}
