using LearningApp.ToDoList.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList.Windows
{
    class StartWindow : Window
    {
        private TextLine titleTextLine;

        public StartWindow() : base(0, 0, 120, 30, "")
        {
            titleTextLine = new TextLine(5, 3, 18, "TO DO LIST");

            AddItemButton = new Button(5, 15, 18, 5, "Add Item");
            AddItemButton.SetActive();

            ShowAllItemsButton = new Button(30, 15, 18, 5, "Show All Items");

            List<Button> ButtonList = new List<Button> { AddItemButton, ShowAllItemsButton };
        }
        //properties
        public Button AddItemButton { get; set; }
        public Button ShowAllItemsButton { get; set; }
        public List<Button> ButtonList { get; set; }

        //methods
        public override void Render()
        {
            base.Render();

            titleTextLine.Render();

            AddItemButton.Render();
            ShowAllItemsButton.Render();

            Console.SetCursorPosition(0, 0);
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
