using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson11.Lesson11_2
{
    class Student
    {

        private string name = "initialName";
        private string color = "initialColor";
        private string city = "initialCity";
        private string value = "initialValue";

        public string Name
        {
            get
            {
                Console.WriteLine(name);
                return name;
                
            }
            set
            {
                name = value;
                Console.WriteLine(name);
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public string City
        {
            set
            {
                city = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }
            private set
            {
                Value = value;
            }
        }

    
        public Student(string name, string color, string city, string value) {
            this.name = name;
            this.color = color;
            this.city = city;
            this.value = value;
        }
    }
}
