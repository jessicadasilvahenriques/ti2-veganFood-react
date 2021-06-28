using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using veganFood.Data;
using veganFood.Models;

namespace veganFood.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotografiasAPIController : ControllerBase
    {
        private readonly VeganDbContext _context;

        public FotografiasAPIController(VeganDbContext context)
        {
            _context = context;
        }

        // GET: api/FotografiasAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FotografiasAPIViewModel>>> GetFotografias()
        {
            return await _context.Fotografias
                                    .Include(f=>f.Receita)
                                    .Select(f=> new FotografiasAPIViewModel {
                                                    IDfotografia = f.IDfotografia,
                                                    Fotografia =f.Fotografia

            })
                                                       
                                                
                
                
                
                
                
                .ToListAsync();

        }

        // GET: api/FotografiasAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fotografias>> GetFotografias(int id)
        {
            var fotografias = await _context.Fotografias.FindAsync(id);

            if (fotografias == null)
            {
                return NotFound();
            }

            return fotografias;
        }

        // PUT: api/FotografiasAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFotografias(int id, Fotografias fotografias)
        {
            if (id != fotografias.IDfotografia)
            {
                return BadRequest();
            }

            _context.Entry(fotografias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotografiasExists(id))
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

        // POST: api/FotografiasAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fotografias>> PostFotografias(Fotografias fotografias)
        {
            _context.Fotografias.Add(fotografias);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFotografias", new { id = fotografias.IDfotografia }, fotografias);
        }

        // DELETE: api/FotografiasAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFotografias(int id)
        {
            var fotografias = await _context.Fotografias.FindAsync(id);
            if (fotografias == null)
            {
                return NotFound();
            }

            _context.Fotografias.Remove(fotografias);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FotografiasExists(int id)
        {
            return _context.Fotografias.Any(e => e.IDfotografia == id);
        }
    }
}
