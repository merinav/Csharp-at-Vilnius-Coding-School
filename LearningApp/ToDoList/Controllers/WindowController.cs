using LearningApp.ToDoList.Constants;
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

        public WindowType CurrentActiveWindow { get; set; }
        public bool ShowAllButtonActive { get; set; }

        public bool AddItemButtonActive { get; set; }

        public void ShowStartWindow()
        {
            CurrentActiveWindow = WindowType.StartWindow;
            startWindow.Render();
        }

        public void ShowAddItemWindow()
        {
            CurrentActiveWindow = WindowType.AddItemWindow;
            addItemWindow.Render();
        }

        public void ShowShowAllWindow()
        {
            CurrentActiveWindow = WindowType.ShowAllItemsWindow;
            showAllWindow.Render();
        }

        public void SetNotActiveStartWindowButton(int id)
        {
            startWindow.ButtonList.ElementAt(id).SetNotActive();
        }

        public void SetActiveStartWindowButton(int id)
        {
            startWindow.ButtonList.ElementAt(id).SetActive();
            startWindow.Render();
            if (id == 0)
            {
                AddItemButtonActive = true;
            }
            else
            {
                ShowAllButtonActive = true;
            }
        }

        
    }
}
