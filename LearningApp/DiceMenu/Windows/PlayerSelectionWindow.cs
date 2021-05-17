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

        private List<Button> playerButtonList = new List<Button>();

        //constructor
        public PlayerSelectionWindow() : base(0, 0, 120, 30, "", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Choose number of players",
                "Do this with arrow buttons and then Enter"});

            playerButtonList.Add(new Button(45, 11, 15, 4, "2"));
            playerButtonList.Add(new Button(61, 11, 15, 4, "3"));
            playerButtonList.Add(new Button(45, 15, 15, 4, "4"));
            playerButtonList.Add(new Button(61, 15, 15, 4, "5"));
            playerButtonList.Add(new Button(45, 19, 15, 4, "6"));
            playerButtonList.Add(new Button(61, 19, 15, 4, "7"));

            playerButtonList[ActiveButtonID].IsActive = true;

        }
        //properties
        public int ActiveButtonID { get; set; } = 0;

        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();


            for (int i = 0; i < playerButtonList.Count; i++)
            {
                playerButtonList[i].Render();
            }

            
            Console.SetCursorPosition(0, 0);
        }

        internal void MoveNext()
        {
            playerButtonList[ActiveButtonID].IsActive = false;
            ActiveButtonID++;
            if (ActiveButtonID >= playerButtonList.Count)
            {
                ActiveButtonID = 0;
            }
            playerButtonList[ActiveButtonID].IsActive = true;
            this.Render();
        }

        internal void MovePrevious()
        {
            playerButtonList[ActiveButtonID].IsActive = false;
            ActiveButtonID--;
            if (ActiveButtonID < 0)
            {
                ActiveButtonID = 0;
            }
            playerButtonList[ActiveButtonID].IsActive = true;
            this.Render();
        }

        internal void MoveUp()
        {
            playerButtonList[ActiveButtonID].IsActive = false;
            ActiveButtonID-=2;
            if (ActiveButtonID < 0)
            {
                ActiveButtonID = 0;
            }
            playerButtonList[ActiveButtonID].IsActive = true;
            this.Render();
        }

        internal void MoveDown()
        {
            playerButtonList[ActiveButtonID].IsActive = false;
            ActiveButtonID += 2;
            if (ActiveButtonID >= playerButtonList.Count)
            {
                ActiveButtonID = 0;
            }
            playerButtonList[ActiveButtonID].IsActive = true;
            this.Render();
        }

       
    }
}
