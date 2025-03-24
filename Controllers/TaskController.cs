using CompTask_Web.Data;
using CompTask_Web.Models.Identity;
using CompTask_Web.Models.Entities;
using CompTask_Web.Models.ViewModels.UserTask;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CompTask_Web.Models.Enums;

using Microsoft.EntityFrameworkCore;

// -- INCOMPLETO --
// CONTROLADOR PARA O CRUD DAS TAREFAS
// E FILTROS E BUSCAS 

namespace CompTask_Web.Controllers
{
    [Authorize] // só  usuarios autenticados acessam
    public class TasksController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TasksController(AppDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Create() // GET: Tasks/Create (feito)
        {
            return View(new TaskCreateViewModel());
            // ifs para aplicar filtros?
        }

        /*public async Task<IActionResult> Index()
        {
            // Verifica e atualiza tarefas pendentes atrasadas
            var overdueTasks = await _context.Tasks
                .Where(t => t.TaskStatus == Status.Pending && t.DueDate < DateTime.Now)
                .ToListAsync();

            foreach (var task in overdueTasks)
            {
                task.TaskStatus = Status.Overdue;
            }
            await _context.SaveChangesAsync();

            // Retorna todas as tarefas (incluindo as atualizadas)
            var tasks = await _context.Tasks.ToListAsync();
            return View(tasks);
        }*/

        
        [HttpPost]
        public async Task<IActionResult> Create(TaskCreateViewModel model) // POST: Tasks/Create(feito)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                
                var task = new UserTask // Converte ViewModel para Entidade
                {
                    Title = model.Title,
                    Description = model.Description,
                    DueDate = model.DueDate,
                    TaskPriority = model.TaskPriority,
                    UserId = user.Id 
                };

                _context.Tasks.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        
        /*public async Task<IActionResult> Edit(int id) // GET: TASKS/EDIT (falta) 
        {

        }

        [HttpPost]
        public async Task<> Edit(int id, TaskEditViewModel model)// POST: TASKS/EDIT (falta)
        {

        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id) // POST: TASKS/DELETE (feito)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));


        }

        [HttpPost]
        public async Task<IActionResult> ToggleStatus(int id)// POST: Tasks/ToggleStatus(Marca como concluída) (feito)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
            {
                return NotFound();
            }

            task.TaskStatus = task.TaskStatus switch
            {
                Status.Pending => Status.Completed,
                Status.Completed => Status.Pending,
                Status.Overdue => Status.Completed,
                _ => task.TaskStatus

            };

            if (task.TaskStatus == Status.Pending && task.DueDate < DateTime.Now)
            {
                task.TaskStatus = Status.Overdue;
            }

            _context.Update(task);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
/*
[Authorize] // só  usuarios autenticados acessam
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TaskController(
            AppDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }


        public async<IActionResult> Index(FilterViewModel filter)// GET: tasks (com filtros)
        {
            
            
            // ifs para aplicar filtros?


        }
        
        public IActionResult Create() //GET: Tasks/Create (feito)
        {
            return View(new TaskViewModel());
        }


        [HttpPost]
        public async Task<IActionResult> Create(TaskViewModel model)//POST: tasks/Create
        {

        }

    

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id) // POST: TASKS/DELETE (feito)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));


        }

        [HttpPost]
        public async Task<IActionResult> ToggleStatus(int id)// POST: Tasks/ToggleStatus(Marca como concluída) (feito)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
                _context.Update(task);
                await _context.SaveChangesAsync();

            }
            return RedirectToAction(nameof(Index));

        }
    }
*/