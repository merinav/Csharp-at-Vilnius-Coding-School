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
        private ShowAllWindow showAllWindow;

        public WindowController()
        {
            startWindow = new StartWindow();
            addItemWindow = new AddItemWindow();
            showAllWindow = new ShowAllWindow();
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

        public void ShowShowAllWindow()
        {
            //CurrentActiveWindow = WindowType.MainMenu;
            showAllWindow.Render();
        }
    }
}
