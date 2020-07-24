using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeList.Controllers
{
    public class BirdsController : Controller
    {
        // GET: BirdsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BirdsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BirdsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BirdsController/Create
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

        // GET: BirdsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BirdsController/Edit/5
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

        // GET: BirdsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BirdsController/Delete/5
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
