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
            GameController MyGame = new GameController();
            MyGame.StartGame();
        }
    }
}
