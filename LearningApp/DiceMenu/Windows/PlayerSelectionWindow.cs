using LearningApp.DiceMenu.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.Windows
{   
    /// <summary>
    /// Shows Player Selection Window
    /// </summary>
    class PlayerSelectionWindow : Window
    {
        private TextBlock titleTextBlock;

        //constructor
        public PlayerSelectionWindow() : base(0, 0, 120, 30, "", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Choose number of players",
                "Do this with arrow buttons and press enter"});

            P2Button = new Button(45, 11, 15, 4, "2");
            //StartButton.SetActive();

            P3Button = new Button(61, 11, 15, 4, "3");
            P4Button = new Button(45, 15, 15, 4, "4");
            P5Button = new Button(61, 15, 15, 4, "5");
            P6Button = new Button(45, 19, 15, 4, "6");
            P7Button = new Button(61, 19, 15, 4, "7");

            List<Button> ButtonList = new List<Button> { P2Button, P3Button, P4Button, 
            P5Button, P6Button, P7Button };
        }
        //properties
        public Button P2Button { get; set; }
        public Button P3Button { get; set; }
        public Button P4Button { get; set; }
        public Button P5Button { get; set; }
        public Button P6Button { get; set; }
        public Button P7Button { get; set; }
        public List<Button> ButtonList { get; set; }

        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            P2Button.Render();
            P3Button.Render();
            P4Button.Render();
            P5Button.Render();
            P6Button.Render();
            P7Button.Render();

            Console.SetCursorPosition(0, 0);
        }

    }
}
