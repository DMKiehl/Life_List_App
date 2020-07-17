using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeList.Controllers
{
    public class Birders : Controller
    {
        // GET: Birders
        public ActionResult Index()
        {
            return View();
        }

        // GET: Birders/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Birders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Birders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Birders/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Birders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Birders/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Birders/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
