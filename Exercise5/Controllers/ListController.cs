using Microsoft.AspNetCore.Mvc;
using Exercise5.DataContext;
using Exercise5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise5.Controllers
{
    public class ListController : Controller
    {
        private readonly ListDbContext _cruddbcontext;

        public ListController(ListDbContext crudDbContext)
        {
            _cruddbcontext = crudDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactTrace(List u)
        {
            if (ModelState.IsValid)
            {
                _cruddbcontext.Lists.Add(u);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("Allusers");
            }
            return View("Index");
        }
        public IActionResult AllUsers()
        {
            return View(_cruddbcontext.Lists.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var user = _cruddbcontext.Lists.FirstOrDefault(u => u.UserId == id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(List u)
        {
            if (u == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _cruddbcontext.Update(u);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("Allusers");
            }
            return View("Edit");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var user = _cruddbcontext.Lists.FirstOrDefault(u => u.UserId == id);

            if (user == null)
            {
                return NotFound();
            }
            _cruddbcontext.Remove(user);
            _cruddbcontext.SaveChanges();

            return RedirectToAction("Allusers");
        }
    }
}