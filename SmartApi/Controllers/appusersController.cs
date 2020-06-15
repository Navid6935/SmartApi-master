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
    public class appusersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public appusersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/appusers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<appusers>>> Getappusers()
        {
            return await _context.appusers.ToListAsync();
        }

        // GET: api/appusers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<appusers>> Getappusers(int id)
        {
            var appusers = await _context.appusers.FindAsync(id);

            if (appusers == null)
            {
                return NotFound();
            }

            return appusers;
        }

        // PUT: api/appusers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putappusers(int id, appusers appusers)
        {
            if (id != appusers.id)
            {
                return BadRequest();
            }

            _context.Entry(appusers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!appusersExists(id))
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

        // POST: api/appusers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<appusers>> Postappusers(appusers appusers)
        {
            _context.appusers.Add(appusers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getappusers", new { id = appusers.id }, appusers);
        }

        // DELETE: api/appusers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<appusers>> Deleteappusers(int id)
        {
            var appusers = await _context.appusers.FindAsync(id);
            if (appusers == null)
            {
                return NotFound();
            }

            _context.appusers.Remove(appusers);
            await _context.SaveChangesAsync();

            return appusers;
        }

        private bool appusersExists(int id)
        {
            return _context.appusers.Any(e => e.id == id);
        }
    }
}
