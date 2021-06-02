using LearningApp.ToDoList.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList.Controllers
{
    class WindowController
    {
        private StartWindow startWindow;
        private AddItemWindow addItemWindow;

        public WindowController()
        {
            startWindow = new StartWindow();
            addItemWindow = new AddItemWindow();
        }

        //public WindowType CurrentActiveWindow { get; set; }

        public void ShowStartWindow()
        {
            //CurrentActiveWindow = WindowType.MainMenu;
            startWindow.Render();
        }

        public void ShowAddItemWindow()
        {
            //CurrentActiveWindow = WindowType.PlayerSelection;
            addItemWindow.Render();
        }
    }
}
