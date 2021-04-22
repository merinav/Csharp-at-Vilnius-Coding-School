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
            GameScreen gameScreen = new GameScreen(40, 200);
            gameScreen.SetHero(new Hero(5, 5, "Hero"));
            gameScreen.Render();
            int uniqueID = 0;
            Random rnd = new Random();            
            for (int i = 0; i < 10; i++)
            {
                gameScreen.AddEnemy(new Enemy(uniqueID, rnd.Next(0,10), rnd.Next(0,10),
                    "EnemyNo" + uniqueID));
                uniqueID++;              
            }
            gameScreen.Render();
            gameScreen.MoveHeroLeft();
            gameScreen.MoveAllEnemiesDown();
            gameScreen.GetEnemyById(0).MoveDown();
            gameScreen.Render();
        }
    }
}
