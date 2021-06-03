using LearningApp.ToDoList.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList.Windows
{
    class AddItemWindow : Window
    {
        private TextLine titleTextLine;

        public AddItemWindow() : base(0, 0, 120, 30, "")
        {
            titleTextLine = new TextLine(5, 3, 18, "Enter your item:");

            ConfirmButton = new Button(5, 15, 18, 5, "Confirm Item");
        }
        public Button ConfirmButton { get; set; }
        
        public override void Render()
        {
            base.Render();

            titleTextLine.Render();

            ConfirmButton.Render();
            
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
