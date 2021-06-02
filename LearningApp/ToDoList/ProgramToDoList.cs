using LearningApp.ToDoList.Controllers;
using LearningApp.ToDoList.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList
{
    class ProgramToDoList
    {
        static void Main() 
        {


            ////taskList.Add("Dishes", "Need to finish dishes after dinner.");

            //for (int i = 0; i < 2; i++)
            //{
            //    taskList.AddNewTaskItem();
            //}

            ////taskList.NewTaskItem();
            //taskList.DisplayList();

            //taskList.RemoveTaskItem(1);

            //taskList.DisplayList();
            TaskList taskList = new TaskList();


            WindowController windowController = new WindowController();

            windowController.ShowStartWindow();
        }

    }
}
