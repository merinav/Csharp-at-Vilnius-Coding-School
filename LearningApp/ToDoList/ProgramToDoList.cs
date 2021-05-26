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
            TaskList taskList = new TaskList();

            //taskList.Add("Dishes", "Need to finish dishes after dinner.");

            for (int i = 0; i < 2; i++)
            {
                taskList.NewTaskItem();
            }
            
            
            
            //taskList.NewTaskItem();
            taskList.DisplayList();
        }

    }
}
