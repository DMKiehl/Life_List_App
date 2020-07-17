using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LifeList.Data;
using LifeList.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LifeList.Controllers
{
    public class BirdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public BirdersController(ApplicationDbContext context)
        {
            _context = context;
        }

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

        public ActionResult Details(int id)
        {

            var birder = _context.Birder.Where(b => b.BirderId == id).SingleOrDefault();
            return View(birder);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Birder birder)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                birder.IdentityUserId = userId;
                _context.Add(birder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", birder.IdentityUserId);
            return View(birder);
            
        }

        public ActionResult Edit(int id)
        {
            var birder = _context.Birder.Where(b => b.BirderId == id).SingleOrDefault();
            return View(birder);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Birder birder)
        {
            if (id != birder.BirderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(birder);
                    await _context.SaveChangesAsync();
                   
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BirderExists(birder.BirderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(birder);

        }

        private bool BirderExists(int birderId)
        {
            return _context.Birder.Any(b => b.BirderId == birderId);
           
        }
       
    }
}
