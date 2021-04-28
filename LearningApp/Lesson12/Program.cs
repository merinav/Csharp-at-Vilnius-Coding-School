using LearningApp.Lesson12.Animals;
using LearningApp.Lesson12.GUI;
using LearningApp.Lesson12.Interfaces;
using LearningApp.Lesson12.LessonTaskInterface;
using LearningApp.Lesson12.LessonTaskInterface.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson12
{
    class Program
    {
        //polimorfizmas
        //ziureti i objekta is skirtingu poziurio tasku


        static void Main() 
        {
            /*
            Pet pet = new Pet(); // pirmas poziurio taskas i pet

            Animal animal = pet; // antras poziurio taskas i pet

            IRenderable renderable = pet; // trecias poziurio taskas i pet, siauriausias siuo atveju
            renderable.Render();

            Image img = new Image();
            */

            Hero hero = new Hero("HeroestHero");
            Dog dog = new Dog("Lucky");
            Ghost ghost = new Ghost(354, "Spooky");
            House house = new House("white", 3);
            Sun sun = new Sun(false);

            Printer printer = new Printer();

            printer.AddPrintableItem(house);
            printer.AddPrintableItem(hero);
            printer.AddPrintableItem(ghost);
            printer.AddPrintableItem(dog);
            printer.AddPrintableItem(sun);

            printer.PrintAll();

            house.Print();
            ghost.Print();

                //IRenderable[] array = new IRenderable[] { hero, dog, ghost, house, sun };

                //Renderer renderer = new Renderer();
                //renderer.AddRenderItem();
           
            //static void GetX(Interface item) 
            //{
            //    Console.WriteLine(item.X);
            //}

            //GetX(dog);
        }
    }
}
