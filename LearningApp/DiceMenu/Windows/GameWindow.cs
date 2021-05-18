using LearningApp.DiceMenu.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.Windows
{
    class GameWindow : Window
    {
        //private fields
        private TextBlock titleTextBlock;

        //constructor
        public GameWindow() : base(0, 0, 120, 30, "", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "GAME GAME GAME"});

            PlayButton = new Button(30, 13, 18, 5, "GAME");

           
        }
        //properties
        public Button PlayButton { get; set; }
        

        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            PlayButton.Render();
           
            Console.SetCursorPosition(0, 0);
        }

    }
}
