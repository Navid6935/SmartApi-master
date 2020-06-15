using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartApi.Models;

namespace SmartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUpdatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppUpdatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AppUpdates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUpdate>>> GetAppUpdate()
        {
            return await _context.AppUpdate.ToListAsync();
        }

        // GET: api/AppUpdates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUpdate>> GetAppUpdate(int id)
        {
            var appUpdate = await _context.AppUpdate.FindAsync(id);

            if (appUpdate == null)
            {
                return NotFound();
            }

            return appUpdate;
        }

        // PUT: api/AppUpdates/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUpdate(int id, AppUpdate appUpdate)
        {
            if (id != appUpdate.id)
            {
                return BadRequest();
            }

            _context.Entry(appUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUpdateExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AppUpdates
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AppUpdate>> PostAppUpdate(AppUpdate appUpdate)
        {
            _context.AppUpdate.Add(appUpdate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppUpdate", new { id = appUpdate.id }, appUpdate);
        }

        // DELETE: api/AppUpdates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppUpdate>> DeleteAppUpdate(int id)
        {
            var appUpdate = await _context.AppUpdate.FindAsync(id);
            if (appUpdate == null)
            {
                return NotFound();
            }

            _context.AppUpdate.Remove(appUpdate);
            await _context.SaveChangesAsync();

            return appUpdate;
        }

        private bool AppUpdateExists(int id)
        {
            return _context.AppUpdate.Any(e => e.id == id);
        }
    }
}
