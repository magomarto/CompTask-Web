using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompTask_Web.Models.ViewModels.UserTask
{
    public class TaskListViewModel
    {
        public List<Task> UserTasks { get; set; }
        public FilterViewModel Filter { get; set; }
    }
}