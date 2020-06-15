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
    public class EsSerialActivesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EsSerialActivesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EsSerialActives
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EsSerialActive>>> GetEsSerialActive()
        {
            return await _context.EsSerialActive.ToListAsync();
        }

        // GET: api/EsSerialActives/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EsSerialActive>> GetEsSerialActive(int id)
        {
            var esSerialActive = await _context.EsSerialActive.FindAsync(id);

            if (esSerialActive == null)
            {
                return NotFound();
            }

            return esSerialActive;
        }

        // PUT: api/EsSerialActives/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEsSerialActive(int id, EsSerialActive esSerialActive)
        {
            if (id != esSerialActive.id)
            {
                return BadRequest();
            }

            _context.Entry(esSerialActive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsSerialActiveExists(id))
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

        // POST: api/EsSerialActives
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EsSerialActive>> PostEsSerialActive(EsSerialActive esSerialActive)
        {
            _context.EsSerialActive.Add(esSerialActive);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEsSerialActive", new { id = esSerialActive.id }, esSerialActive);
        }

        // DELETE: api/EsSerialActives/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EsSerialActive>> DeleteEsSerialActive(int id)
        {
            var esSerialActive = await _context.EsSerialActive.FindAsync(id);
            if (esSerialActive == null)
            {
                return NotFound();
            }

            _context.EsSerialActive.Remove(esSerialActive);
            await _context.SaveChangesAsync();

            return esSerialActive;
        }

        private bool EsSerialActiveExists(int id)
        {
            return _context.EsSerialActive.Any(e => e.id == id);
        }
    }
}
