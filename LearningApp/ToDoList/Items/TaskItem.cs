using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList
{
     class TaskItem
    {
        public int Id { get; set; }
        public string TaskTopic { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem() { }

        public TaskItem(string topic, string task)
        {
            TaskTopic = topic;
            Task = task;
            IsCompleted = false;
        }
        public TaskItem(int id, string topic, string task)
        {
            Id = id;
            TaskTopic = topic;
            Task = task;
            IsCompleted = false;
        }
    }
}
