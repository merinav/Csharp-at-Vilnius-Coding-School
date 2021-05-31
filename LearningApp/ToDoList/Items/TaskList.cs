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
        public TaskList()
        {
            ListOfTasks = new List<TaskItem>();
        }

        public void Add(string topic, string task)
        {
            int tasksId = ListOfTasks.Count();
            int id = tasksId++;

            ListOfTasks.Add(new TaskItem(id, topic, task));
        }

        public void DisplayList()
        {
            //Console.Clear();
            Console.WriteLine("Your To-Do List");
            Console.WriteLine();
            Console.WriteLine("No |  Topic  |  Task  | Completed");
            Console.WriteLine();
            foreach (var t in ListOfTasks)
            {
            Console.WriteLine("{0}     {1}\t{2}\t{3}", t.Id.ToString(),
                                                     t.TaskTopic,
                                                     t.Task,
                                                     t.IsCompleted);
            }
        }

        public void AddNewTaskItem()
        {
            Console.Write("Enter topic: ");
            string topic = Console.ReadLine();
           
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            Console.WriteLine();

            this.Add(topic, task);
        }

        public void RemoveTaskItem(int id) 
        {
            ListOfTasks.RemoveAt(id);
        }

        public string GetTask(int id)
        {
            var result = from t in ListOfTasks
                          where t.Id == id
                          select t.Task;

            List<string> list = new List<string>();
            list = result.ToList();

            var firstItem = list.ElementAt(0);

            return firstItem;
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
