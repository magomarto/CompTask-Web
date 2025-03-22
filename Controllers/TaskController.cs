using CompTask_Web.Data;
using CompTask_Web.Models.Identity;
using CompTask_Web.Models.Entities;
using CompTask_Web.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// CONTROLADOR PARA O CRUD DAS TAREFAS
// E FILTROS E BUSCAS

namespace CompTask_Web.Controllers
{
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

        public async Task<IActionResult> Edit(int id) // GET: TASKS/EDIT
        {

        }

        [HttpPost]
        public async Task<> Edit(int id, TaskViewModel model)// POST: TASKS/EDIT
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
}