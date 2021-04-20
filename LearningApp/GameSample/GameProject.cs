using LearningApp.GameSample.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningApp.GameSample
{
    class GameProject
    {
        static void Main() 
        {
            //create and move hero
            Hero testHero = new Hero(10, 10, "testHero");
            testHero.PrintInfo();
            testHero.MoveLeft();
            testHero.PrintInfo();

            // create and move enemies
            int enemyCount = 0;
            Random rnd = new Random();
            
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }
            foreach (Enemy enemy in enemies)
            {
                enemy.PrintInfo();
            }

            Animal animal = new Animal(2);
            animal.Live();

            Bird bird = new Bird(5, "red");
            bird.Live();
            bird.Fly();
            


        }
    }
}
