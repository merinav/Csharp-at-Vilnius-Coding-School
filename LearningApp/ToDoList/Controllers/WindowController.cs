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

        public bool GoToMainButtonActive { get; set; }

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

        public void SetAddItemButtonStart(bool set)
        {
            if (set)
            {
                startWindow.AddItemButton.SetActive();
                startWindow.ShowAllItemsButton.SetNotActive();
                AddItemButtonActive = true;
                ShowAllButtonActive = false;
            }
            else
            {
                startWindow.AddItemButton.SetNotActive();
                startWindow.ShowAllItemsButton.SetActive();
                ShowAllButtonActive = true;
                AddItemButtonActive = false;
            }   
        }

        public void SetAddItemsButtonShowAll(bool set)
        {
            if (set)
            {
                showAllWindow.AddItemButton.SetActive();
                showAllWindow.GoToMainButton.SetNotActive();
                AddItemButtonActive = true;
                GoToMainButtonActive = false;
            }
            else
            {
                showAllWindow.AddItemButton.SetNotActive();
                showAllWindow.GoToMainButton.SetActive();
                GoToMainButtonActive = true;
                AddItemButtonActive = false;
            }
        }


    }
}
