using LearningApp.DiceMenu.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.Windows
{
    class DiceSelectionWindow : Window
    {

        //private fields
        private TextBlock titleTextBlock;

        //constructor
        public DiceSelectionWindow() : base(0, 0, 120, 30, "", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { 
                "How many dice shall each player play?",
                "Choose by clicking + or - and then Enter"});

            diceButton = new Button(50, 13, 18, 5, "5");
        }
        //properties
        public Button diceButton { get; set; }
       
        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            diceButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
