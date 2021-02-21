using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDepartman.Models;

namespace CoreDepartman.Controllers
{
    public class departController : Controller
    {
        context c = new context();
        public IActionResult Index()
        {
            var degerler = c.departmanlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            c.departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int id)
        {
            var departman = c.departmanlars.Find(id);
            c.departmanlars.Remove(departman);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Guncelle(int id)
        {
            var guncelle = c.departmanlars.Find(id);
            return View("Guncelle", guncelle);
        }
        public IActionResult GuncellemeYap(departmanlar d)
        {
            var gncl = c.departmanlars.Find(d.ID);
            gncl.departmanad = d.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
