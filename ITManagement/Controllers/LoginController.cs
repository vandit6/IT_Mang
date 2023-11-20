using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITManagement.Controllers
{
    public class LoginController : Controller
    {
        private readonly ITManagementContext ITM;
        public LoginController(ITManagementContext _ITM)
        {
            ITM = _ITM;
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}