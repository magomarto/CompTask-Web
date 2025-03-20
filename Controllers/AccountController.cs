using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CompTask_Web.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// CONTROLADOR DE AUTENTICAÇÃO : LOGIN, REGISTRO, LOGOUT

namespace CompTask_Web.Controllers
{
    [AllowAnonymous] //aACESSO SEM AUTENTICAÇÃO
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login() // GET: Account/Login
        {

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) // POST: Account/Login
        {

        }

        public IActionResult Register()// GET: Account/Register
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)//POST: Account/Register
        {

        }

        [HttpPost]
        public async<IActionResult> Logout() //POST: ACCOUNT/Logout

        {

        }
    }
}