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
    public class StoredSerialsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StoredSerialsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/StoredSerials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoredSerials>>> GetStoredSerials()
        {
            return await _context.StoredSerials.ToListAsync();
        }

        // GET: api/StoredSerials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoredSerials>> GetStoredSerials(int id)
        {
            var storedSerials = await _context.StoredSerials.FindAsync(id);

            if (storedSerials == null)
            {
                return NotFound();
            }

            return storedSerials;
        }

        // PUT: api/StoredSerials/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoredSerials(int id, StoredSerials storedSerials)
        {
            if (id != storedSerials.id)
            {
                return BadRequest();
            }

            _context.Entry(storedSerials).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoredSerialsExists(id))
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

        // POST: api/StoredSerials
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StoredSerials>> PostStoredSerials(StoredSerials storedSerials)
        {
            _context.StoredSerials.Add(storedSerials);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoredSerials", new { id = storedSerials.id }, storedSerials);
        }

        // DELETE: api/StoredSerials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StoredSerials>> DeleteStoredSerials(int id)
        {
            var storedSerials = await _context.StoredSerials.FindAsync(id);
            if (storedSerials == null)
            {
                return NotFound();
            }

            _context.StoredSerials.Remove(storedSerials);
            await _context.SaveChangesAsync();

            return storedSerials;
        }

        private bool StoredSerialsExists(int id)
        {
            return _context.StoredSerials.Any(e => e.id == id);
        }
    }
}
