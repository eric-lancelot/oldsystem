using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using v1jobportal.Data;
using v1jobportal.Models;

namespace v1jobportal.Controllers
{
    public class SubmittedApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubmittedApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubmittedApplications
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubmittedApplication.ToListAsync());
        }

        // GET: SubmittedApplications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submittedApplication = await _context.SubmittedApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submittedApplication == null)
            {
                return NotFound();
            }

            return View(submittedApplication);
        }

        // GET: SubmittedApplications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubmittedApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Jd_JobId,Jd_JobTitle,Bd_FirstName,Bd_MiddleName,Bd_LastName,Bd_Residence,Bd_PrimaryPhoneNumber,Bd_AlternativePhoneNumber,Bd_LanguagesSpoken,Bd_WorkedWithIDRC,Ed_NameOfInstitution,Ed_QualificationAttained,Ed_DateQualificationWasAttained,Eh_EmployerName,Eh_EmploymentStartDate,Eh_EmploymentEndDate,Eh_JobTitle,Eh_SummaryOfDuties,Eh_SummaryOfAchievments,Ca_CertificationName,Ca_CertifyingInstitutionName,Ca_CertificationDate,Ud_CertificationAwardName,Ud_InstitutionName,Ud_DateOfCertification")] SubmittedApplication submittedApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(submittedApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(submittedApplication);
        }

        // GET: SubmittedApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submittedApplication = await _context.SubmittedApplication.FindAsync(id);
            if (submittedApplication == null)
            {
                return NotFound();
            }
            return View(submittedApplication);
        }

        // POST: SubmittedApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Jd_JobId,Jd_JobTitle,Bd_FirstName,Bd_MiddleName,Bd_LastName,Bd_Residence,Bd_PrimaryPhoneNumber,Bd_AlternativePhoneNumber,Bd_LanguagesSpoken,Bd_WorkedWithIDRC,Ed_NameOfInstitution,Ed_QualificationAttained,Ed_DateQualificationWasAttained,Eh_EmployerName,Eh_EmploymentStartDate,Eh_EmploymentEndDate,Eh_JobTitle,Eh_SummaryOfDuties,Eh_SummaryOfAchievments,Ca_CertificationName,Ca_CertifyingInstitutionName,Ca_CertificationDate,Ud_CertificationAwardName,Ud_InstitutionName,Ud_DateOfCertification")] SubmittedApplication submittedApplication)
        {
            if (id != submittedApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(submittedApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubmittedApplicationExists(submittedApplication.Id))
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
            return View(submittedApplication);
        }

        // GET: SubmittedApplications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var submittedApplication = await _context.SubmittedApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (submittedApplication == null)
            {
                return NotFound();
            }

            return View(submittedApplication);
        }

        // POST: SubmittedApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var submittedApplication = await _context.SubmittedApplication.FindAsync(id);
            _context.SubmittedApplication.Remove(submittedApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubmittedApplicationExists(int id)
        {
            return _context.SubmittedApplication.Any(e => e.Id == id);
        }
    }
}
