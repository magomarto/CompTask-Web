using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompTask_Web.Models.Enums;

namespace CompTask_Web.Models.ViewModels.UserTask
{
    public class FilterViewModel
    {
        // filtros
        public string SearchText { get; set; }
        public Priority? Priority { get; set; }
        // mostrar completas
        public bool ShowCompleted { get; set; }
    }
}