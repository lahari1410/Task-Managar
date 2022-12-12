using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ViewModel
{
    public class Task
    {
        
            public string Name { get; set; }
            public string Description { get; set; }
            public string Time { get; set; }
            public Boolean Reminder { get; set; }
       
    }
}
