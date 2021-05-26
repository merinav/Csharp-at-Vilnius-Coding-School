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

        public void NewTaskItem()
        {
            Console.Write("Enter topic: ");
            string topic = Console.ReadLine();
            //Console.WriteLine(topic);
            //Console.WriteLine();

            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            //Console.WriteLine(task);
            Console.WriteLine();

            //Console.Write("Enter deadline: ");
            //string task = Console.ReadLine();
            ////Console.WriteLine(task);
            //Console.WriteLine();

            this.Add(topic, task);
        }
    }
}
