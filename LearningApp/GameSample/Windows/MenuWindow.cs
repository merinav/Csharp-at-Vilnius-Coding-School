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
        private Button startButton;
        private Button creditsButton;
        private Button quitButton;
        private TextBlock titleTextBlock;
        private List<Button> buttonList = new List<Button> { };

        //constructor
        public MenuWindow() : base(0, 0, 120, 30, "Game menu!", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            startButton = new Button(20, 13, 18, 5, "Start");
            startButton.SetActive();

            creditsButton = new Button(50, 13, 18, 5, "Credits");

            quitButton = new Button(80, 13, 18, 5, "Quit");

            buttonList.Add(startButton);
            buttonList.Add(creditsButton);
            buttonList.Add(quitButton);
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

            startButton.Render();
            creditsButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }

        public void OnlyQuitButtonActive() 
        {
            quitButton.SetActive();
            startButton.SetNotActive();
            creditsButton.SetNotActive();
            this.Render();
        }

        public void OnlyCreditsButtonActive()
        {
            creditsButton.SetActive();
            startButton.SetNotActive();
            quitButton.SetNotActive();
            this.Render();
        }

        public void OnlyStartButtonActive()
        {
            quitButton.SetNotActive();
            startButton.SetActive();
            creditsButton.SetNotActive();
            this.Render();
        }

        public void ActivateButton(int buttonNumber) 
        {
            if (buttonNumber == 0)
            {
                OnlyStartButtonActive();
            }
            else if (buttonNumber == 1)
            {
                OnlyCreditsButtonActive();
            }
            else if (buttonNumber == 2)
            {
                OnlyQuitButtonActive();
            }
        }
    }
}
