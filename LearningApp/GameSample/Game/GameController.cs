using LearningApp.GameSample.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class GameController
    {
        public GameController() 
        {
        
        }

        public void StartGame() 
        {
            GameScreen gameScreen = new GameScreen(40, 200);
            gameScreen.SetHero(new Hero(5, 5, "Hero"));
            gameScreen.Render();
            int uniqueID = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                gameScreen.AddEnemy(new Enemy(uniqueID, rnd.Next(0, 10), rnd.Next(0, 10),
                    "EnemyNo" + uniqueID));
                uniqueID++;
            }
            gameScreen.Render();
            gameScreen.MoveHeroLeft();
            gameScreen.MoveAllEnemiesDown();
            gameScreen.GetEnemyById(0).MoveDown();
            gameScreen.Render();
        }

        public void InitGame() 
        {
        
        }

        public void StartGameLoop()
        {

        }
    }
}
