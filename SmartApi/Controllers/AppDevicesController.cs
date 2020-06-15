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
    public class AppDevicesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppDevicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AppDevices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppDevices>>> GetAppDevices()
        {
            return await _context.AppDevices.ToListAsync();
        }

        // GET: api/AppDevices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppDevices>> GetAppDevices(int id)
        {
            var appDevices = await _context.AppDevices.FindAsync(id);

            if (appDevices == null)
            {
                return NotFound();
            }

            return appDevices;
        }

        // PUT: api/AppDevices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppDevices(int id, AppDevices appDevices)
        {
            if (id != appDevices.id)
            {
                return BadRequest();
            }

            _context.Entry(appDevices).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppDevicesExists(id))
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

        // POST: api/AppDevices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AppDevices>> PostAppDevices(AppDevices appDevices)
        {
            _context.AppDevices.Add(appDevices);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppDevices", new { id = appDevices.id }, appDevices);
        }

        // DELETE: api/AppDevices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AppDevices>> DeleteAppDevices(int id)
        {
            var appDevices = await _context.AppDevices.FindAsync(id);
            if (appDevices == null)
            {
                return NotFound();
            }

            _context.AppDevices.Remove(appDevices);
            await _context.SaveChangesAsync();

            return appDevices;
        }

        private bool AppDevicesExists(int id)
        {
            return _context.AppDevices.Any(e => e.id == id);
        }
    }
}
