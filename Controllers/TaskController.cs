//using CompTask_Web.Data;
//using Comptask_Web.Models.Identity;
//using Comptask_Web.Models.Entities;
//using Comptask_Web.Models.ViewModels;
using CompTask_Web.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


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
        
        public IActionResult Create() //GET: Tasks/Create
        {

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
        public async Task<IActionResult> Delete(int id) // POST: TASKS/DELETE
        {


        }

        [HttpPost]
        public async Task<IActionResult> ToggleStatus(int id)// POST: Tasks/ToggleStatus(Marca como concluída)
        {

        }
    }
}