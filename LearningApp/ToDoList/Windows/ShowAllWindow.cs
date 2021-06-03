using LearningApp.ToDoList.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList.Windows
{
    class ShowAllWindow : Window
    {

        private TextLine titleTextLine;

        public ShowAllWindow() : base(0, 0, 120, 30, "")
        {
            titleTextLine = new TextLine(5, 3, 18, "ALL ITEMS ON YOUR TO DO LIST");

            AddItemButton = new Button(5, 15, 18, 5, "Add Item");

            GoToMainButton = new Button(30, 15, 18, 5, "Go To Main Window");

            List<Button> ButtonList = new List<Button> { AddItemButton, GoToMainButton };
        }
        //properties
        public Button AddItemButton { get; set; }
        public Button GoToMainButton { get; set; }

        public List<Button> ButtonList { get; set; }

        public override void Render()
        {
            base.Render();

            titleTextLine.Render();

            AddItemButton.Render();
            GoToMainButton.Render();

            Console.SetCursorPosition(5, 10);
        }

        public void SetActive(Button button)
        {
            button.SetActive();
        }

        public void SetNotActive(Button button)
        {
            button.SetNotActive();
        }


    }
}
