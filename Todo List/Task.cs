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
        private string importance;
        public DateTime timeAdded;

        public Task(string _taskname, string _importance)
        {
            taskname = _taskname;
            Importance = _importance;
            timeAdded = DateTime.Now;
        }

        public string Importance
        {
            get
            {
                return importance;
            }
            set
            {
                if (value == "Critical" || value == "Important" || value == "Minor")
                {
                    importance = value;
                }else
                {
                    importance = "Important";
                }
            }
        }
    }
}
