using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_List
{
    class Task
    {
        public string taskname;
        public string importance;
        public DateTime timeAdded;

        public Task(string Taskname, string Importance)
        {
            taskname = Taskname;
            importance = Importance;
            timeAdded = DateTime.Now;
        }
    }
}
