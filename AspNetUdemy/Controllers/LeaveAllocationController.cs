using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetUdemy.Data;

namespace AspNetUdemy.Controllers
{
    public class LeaveAllocationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeaveAllocationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LeaveAllocation
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.LeaveAllocations.Include(l => l.Employee).Include(l => l.LeaveType).Include(l => l.Period);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: LeaveAllocation/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveAllocation = await _context.LeaveAllocations
                .Include(l => l.Employee)
                .Include(l => l.LeaveType)
                .Include(l => l.Period)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveAllocation == null)
            {
                return NotFound();
            }

            return View(leaveAllocation);
        }

        // GET: LeaveAllocation/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id");
            ViewData["PeriodId"] = new SelectList(_context.Periods, "Id", "Id");
            return View();
        }

        // POST: LeaveAllocation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LeaveTypeId,EmployeeId,PeriodId,Id")] LeaveAllocation leaveAllocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leaveAllocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Users, "Id", "Id", leaveAllocation.EmployeeId);
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveAllocation.LeaveTypeId);
            ViewData["PeriodId"] = new SelectList(_context.Periods, "Id", "Id", leaveAllocation.PeriodId);
            return View(leaveAllocation);
        }

        // GET: LeaveAllocation/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveAllocation = await _context.LeaveAllocations.FindAsync(id);
            if (leaveAllocation == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Users, "Id", "Id", leaveAllocation.EmployeeId);
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveAllocation.LeaveTypeId);
            ViewData["PeriodId"] = new SelectList(_context.Periods, "Id", "Id", leaveAllocation.PeriodId);
            return View(leaveAllocation);
        }

        // POST: LeaveAllocation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LeaveTypeId,EmployeeId,PeriodId,Id")] LeaveAllocation leaveAllocation)
        {
            if (id != leaveAllocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveAllocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveAllocationExists(leaveAllocation.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Users, "Id", "Id", leaveAllocation.EmployeeId);
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveAllocation.LeaveTypeId);
            ViewData["PeriodId"] = new SelectList(_context.Periods, "Id", "Id", leaveAllocation.PeriodId);
            return View(leaveAllocation);
        }

        // GET: LeaveAllocation/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leaveAllocation = await _context.LeaveAllocations
                .Include(l => l.Employee)
                .Include(l => l.LeaveType)
                .Include(l => l.Period)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveAllocation == null)
            {
                return NotFound();
            }

            return View(leaveAllocation);
        }

        // POST: LeaveAllocation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveAllocation = await _context.LeaveAllocations.FindAsync(id);
            if (leaveAllocation != null)
            {
                _context.LeaveAllocations.Remove(leaveAllocation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveAllocationExists(int id)
        {
            return _context.LeaveAllocations.Any(e => e.Id == id);
        }
    }
}
