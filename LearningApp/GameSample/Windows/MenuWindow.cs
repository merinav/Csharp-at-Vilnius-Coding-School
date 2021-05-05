using LearningApp.GameSample.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Windows
{
    class MenuWindow : Window
    {
        //private fields
        private TextBlock titleTextBlock;
        
        //constructor
        public MenuWindow() : base(0, 0, 120, 30, "Game menu!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            StartButton = new Button(20, 13, 18, 5, "Start");
            StartButton.SetActive();

            CreditsButton = new Button(50, 13, 18, 5, "Credits");

            QuitButton = new Button(80, 13, 18, 5, "Quit");

            List<Button> ButtonList = new List<Button> { StartButton, CreditsButton, QuitButton };
        }
        //properties
        public Button StartButton { get; set; }
        public Button CreditsButton { get; set; }
        public Button QuitButton { get; set; }
        public List<Button> ButtonList { get; set; }

        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            StartButton.Render();
            CreditsButton.Render();
            QuitButton.Render();

            Console.SetCursorPosition(0, 0);
        }

        public void UserMoveLeft() 
        {
            bool startbtn = StartButton.IsActive;
            bool creditsbtn = CreditsButton.IsActive;
            bool quitbtn = QuitButton.IsActive;

            if (startbtn == true || creditsbtn == true)
            {
                StartButton.SetActive();
                CreditsButton.SetNotActive();
                QuitButton.SetNotActive();
                this.Render();
            }
            else if (quitbtn == true)
            {
                StartButton.SetNotActive();
                CreditsButton.SetActive();
                QuitButton.SetNotActive();
                this.Render();
            }
        }

        public void UserMoveRight() 
        {
            bool startbtn = StartButton.IsActive;
            bool creditsbtn = CreditsButton.IsActive;
            bool quitbtn = QuitButton.IsActive;
            if (startbtn == true)
                {
                    StartButton.SetNotActive();
                    CreditsButton.SetActive();
                    QuitButton.SetNotActive();
                    this.Render();
                }
            else if (creditsbtn == true || quitbtn == true)
                {
                    StartButton.SetNotActive();
                    CreditsButton.SetNotActive();
                    QuitButton.SetActive();
                    this.Render();
                }
        }       
        public bool ReturnStartButtonValue() 
        {
            return StartButton.IsActive;
        }

        public bool ReturCreditsButtonValue()
        {
            return CreditsButton.IsActive;
        }

        public bool ReturnQuitButtonValue()
        {
            return QuitButton.IsActive;
        }

    }
}
