using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Welcome to myToDo list ==========");
            Console.Write("Enter task: ");
            string taskname = Console.ReadLine();
            Console.Write("Enter Importance (Critical, Important, Minor): ");
            string importance = Console.ReadLine();

            Task task = new Task(taskname, importance);
            Console.WriteLine("New Task added");
            Console.WriteLine($"Task: {task.taskname}");
            Console.WriteLine($"Importance: {task.Importance}");
            Console.WriteLine($"Time Added: {task.timeAdded}");



            Console.ReadLine();
        }
    }
}
