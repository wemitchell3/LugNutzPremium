﻿using LugNutzEnterprize.Data;
using LugNutzEnterprize.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace LugNutzEnterprize.Controllers
{   [Authorize]
    public class MaintenanceTasksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MaintenanceTasksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: MaintenanceTasks
        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();
            var applicationDbContext = _context.Vehicle.Include(t => t.User).Where(t => t.UserId == currentUser.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MaintenanceTasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTask = await _context.MaintenanceTask
                .FirstOrDefaultAsync(m => m.MaintenanceTaskId == id);
            if (maintenanceTask == null)
            {
                return NotFound();
            }

            return View(maintenanceTask);
        }

        // GET: MaintenanceTasks/Create
        public IActionResult Create()
        {            
            return View();
        }

        // POST: MaintenanceTasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirmed([Bind("MaintenanceTaskId,VehicleId,MaintenanceTaskTitle,MaintenanceTaskDescription,TaskDueAtMileage,IsComplete,DateCreated,TargetCompleteDate")] MaintenanceTask maintenanceTask)
        {
            var currentUser = await GetCurrentUserAsync();
            ModelState.Remove("UserId");
            if (ModelState.IsValid)
            {
                
                _context.Add(maintenanceTask);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(maintenanceTask);
        }

        // GET: MaintenanceTasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTask = await _context.MaintenanceTask.FindAsync(id);
            if (maintenanceTask == null)
            {
                return NotFound();
            }
            return View(maintenanceTask);
        }

        // POST: MaintenanceTasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaintenanceTaskId,VehicleId,MaintenanceTaskTitle,MaintenanceTaskDescription,TaskDueAtMileage,IsComplete,DateCreated,TargetCompleteDate")] MaintenanceTask maintenanceTask)
        {
            if (id != maintenanceTask.MaintenanceTaskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maintenanceTask);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaintenanceTaskExists(maintenanceTask.MaintenanceTaskId))
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
            return View(maintenanceTask);
        }

        // GET: MaintenanceTasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenanceTask = await _context.MaintenanceTask
                .FirstOrDefaultAsync(m => m.MaintenanceTaskId == id);
            if (maintenanceTask == null)
            {
                return NotFound();
            }

            return View(maintenanceTask);
        }

        // POST: MaintenanceTasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var maintenanceTask = await _context.MaintenanceTask.FindAsync(id);
            _context.MaintenanceTask.Remove(maintenanceTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaintenanceTaskExists(int id)
        {
            return _context.MaintenanceTask.Any(e => e.MaintenanceTaskId == id);
        }
    }
}