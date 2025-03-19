using CompTask_Web.Models.Entities;

namespace CompTask_Web.Models.ViewModels
{
    public class FilterViewModel // filtagrem de tarefas por prioridade, status ou texto
    {
        public string SearchText { get; set; }
        public Priority? Priority { get; set; }
        public string? ShowCompleted { get; set; }
    }
}