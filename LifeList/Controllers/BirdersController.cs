using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LifeList.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeList.Controllers
{
    public class BirdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public BirdersController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Birders
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var birderProfile = _context.Birder.Where(b => b.IdentityUserId == userId).ToList();

            if (birderProfile.Count == 0)
            {
                return RedirectToAction("Create", "Birders");
            }

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
