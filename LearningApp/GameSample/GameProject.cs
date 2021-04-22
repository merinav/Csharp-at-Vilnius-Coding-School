using LearningApp.GameSample.Game;
using LearningApp.GameSample.GUI;
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
            GameController gameController = new GameController();
            gameController.StartGame();
            //GameController gameController = new GameController();
            //gameController.StartGame();

            Console.CursorVisible = false;

            Frame frame1 = new Frame(0, 0, 8, 5, '%');
            frame1.Render();
            Frame frame2 = new Frame(19, 5, 22, 3, '@');
            frame2.Render();
            Frame frame3 = new Frame(29, 9, 22, 10, '#');
            frame3.Render();

            TextLine text1 = new TextLine(1, 2, 6, "Hello!");
            text1.Render();
            TextLine text2 = new TextLine(20, 6, 20, "Anybody..");
            text2.Render();
            TextLine text3 = new TextLine(30, 10, 20, "There???");
            text3.Render();

            Console.ReadKey();



        }
    }
}
