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
            titleTextLine = new TextLine(10, 5, 100, "Enter your item");

            ConfirmItemButton = new Button(5, 15, 18, 5, "Confirm your item");

            
        }
        //properties
        public Button ConfirmItemButton { get; set; }
        
        //methods
        public override void Render()
        {
            base.Render();

            titleTextLine.Render();

            ConfirmItemButton.Render();
           
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
