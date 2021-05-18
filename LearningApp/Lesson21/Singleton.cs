using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson21
{
    class Singleton
    {
        static private Singleton instance;

        private Singleton() { }

        public static Singleton Instance() {

            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;

        }


       
    }
}
