using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList
{
    class TaskList 
    {
        public List<TaskItem> ListOfTasks { get; set; }
        public int TaskId { get; set; } 
        public TaskList()
        {
            ListOfTasks = new List<TaskItem>();
        }

        public void Add(string task)
        { 
            ListOfTasks.Add(new TaskItem(task));
        }

        public void DisplayList()
        {
            //Console.SetCursorPosition(5, 10);
            //Console.WriteLine("No | Task ");
            //Console.WriteLine();
            foreach (var t in ListOfTasks)
            {
                Console.SetCursorPosition(5, 10);
                Console.WriteLine((ListOfTasks.IndexOf(t)+1) + $" {t.Task}"); 
            }
        }

        public void RemoveTaskItem(int id) 
        {
            ListOfTasks.RemoveAt(id);
        }

        public List<string> GetAllTasks() 
        {
            var result = from t in ListOfTasks
                         select t.Task;

            List<string> list = new List<string>();
            list = result.ToList();

            return list;
        }

    }
}
