// using CompTask_Web.Data;
// using Comptask_Web.Models.Identity;
//using Comptask_Web.Models.Entities;
//using Comptask_Web.Models.ViewModels;
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
      /*  private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TaskController(
            AppDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }*/


        // GET: tasks (com filtros)
            // aplica filtros
        
        //GET: Tasks/Create

        //POST: tasks/Create

        // GET: TASKS/EDIT

        // POST: TASKS/EDIT

        // POST: TASKS/DELETE

        // POST: Tasks/ToggleStatus(Marca como concluída)
    }

}