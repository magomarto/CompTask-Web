namespace CompTask_Web.Models.ViewModels
{
    public class TaskListViewModel // listar tarefas com filtros
    {
        public List<Task> Tasks { get; set; }
        public FilterViewModel Filter { get; set; }
    }
}