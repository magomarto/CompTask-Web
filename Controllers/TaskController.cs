using CompTask_Web.Data;
using CompTask_Web.Models.Identity;
using CompTask_Web.Models.Entities;
using CompTask_Web.Models.ViewModels.UserTask;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// -- INCOMPLETO --
// CONTROLADOR PARA O CRUD DAS TAREFAS
// E FILTROS E BUSCAS 

namespace CompTask_Web.Controllers
{
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
        }

        
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
                    UserId = user.Id // Definido no controller, não no ViewModel
                };

                _context.Tasks.Add(task);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}