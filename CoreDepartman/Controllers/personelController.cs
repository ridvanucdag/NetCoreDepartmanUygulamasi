using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDepartman.Controllers
{
    public class personelController : Controller
    {
        context c = new context();
        public IActionResult Index()
        {
            var personel = c.personels.ToList();
            return View(personel);
        }
    }
}
