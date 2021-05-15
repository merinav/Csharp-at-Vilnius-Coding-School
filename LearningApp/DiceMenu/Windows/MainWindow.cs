using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.GUI
{
    class MainWindow : Window 
    {

        //private fields
        private TextBlock titleTextBlock;

        //constructor
        public MainWindow() : base(0, 0, 120, 30, "", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "THIS IS YOUR GAME OF DICE",
                "Do you want to play or quit?",
                "Choose by clicking P or Q on your keyboard"});

            PlayButton = new Button(30, 13, 18, 5, "PLAY");
            //StartButton.SetActive();

            QuitButton = new Button(70, 13, 18, 5, "QUIT");

            List<Button> ButtonList = new List<Button> { PlayButton, QuitButton };
        }
        //properties
        public Button PlayButton { get; set; }
        public Button QuitButton { get; set; }
        public List<Button> ButtonList { get; set; }

        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            PlayButton.Render();
            QuitButton.Render();

            Console.SetCursorPosition(0, 0);
        }

    }
}
