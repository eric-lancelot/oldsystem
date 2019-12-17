using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using v1jobportal.Data;
using v1jobportal.Models;

namespace v1jobportal.Controllers
{
    [Authorize]
    public class AllJobListingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllJobListingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult JobManagement()
        {
            return View();
        }
        // GET: AllJobListings
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.AllJobListings.ToListAsync());
        }

        // GET: AllJobListings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allJobListings = await _context.AllJobListings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (allJobListings == null)
            {
                return NotFound();
            }

            return View(allJobListings);
        }

        /// <summary>
        /// Return view ID
        /// </summary>
        /// <param name="allJobListings"></param>
        /// <returns></returns>
        /// 

        public async Task<IActionResult> ViewId(int? id)
        {
            var allJobListings = await _context.AllJobListings.FindAsync(id);
            if (allJobListings == null)
            {
                return NotFound();
            }
            return View("ApplicationBioData/Create");  
        }

        


        // GET: AllJobListings/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: AllJobListings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,JobTitle,DutyStation,Duties,Qualifications,Deadline")] AllJobListings allJobListings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(allJobListings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(allJobListings);
        }

        // GET: AllJobListings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allJobListings = await _context.AllJobListings.FindAsync(id);
            if (allJobListings == null)
            {
                return NotFound();
            }
            return View(allJobListings);
        }

        // POST: AllJobListings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JobTitle,DutyStation,Duties,Qualifications,Deadline")] AllJobListings allJobListings)
        {
            if (id != allJobListings.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allJobListings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllJobListingsExists(allJobListings.Id))
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
            return View(allJobListings);
        }
        //get id of clicked job
        

        // GET: AllJobListings/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allJobListings = await _context.AllJobListings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (allJobListings == null)
            {
                return NotFound();
            }

            return View(allJobListings);
        }

        // POST: AllJobListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var allJobListings = await _context.AllJobListings.FindAsync(id);
            _context.AllJobListings.Remove(allJobListings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllJobListingsExists(int id)
        {
            return _context.AllJobListings.Any(e => e.Id == id);
        }


    }
}
