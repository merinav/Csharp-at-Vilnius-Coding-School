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
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> {
                "How many dice shall each player play?",
                "Choose by clicking + or - and then Enter"});

        }
        //properties
        //public Button diceButton { get; set; }

        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            Console.SetCursorPosition(0, 0);
        }

    }
}
