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
    public class ReceitasAPIController : ControllerBase
    {
        private readonly VeganDbContext _context;

        public ReceitasAPIController(VeganDbContext context)
        {
            _context = context;
        }

        // GET: api/ReceitasAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReceitasAPIViewModel>>> GetReceitas()
        {
            return await _context.Receitas.Select(r => new ReceitasAPIViewModel{ 
                                                IDreceita=r.IDreceita,
                                                Descricao=r.Descricao,
                                                Ingredientes=r.Ingredientes,
                                                ModoPreparo=r.ModoPreparo
                                 })
                
                .ToListAsync();
        }

        // GET: api/ReceitasAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Receitas>> GetReceitas(int id)
        {
            var receitas = await _context.Receitas.FindAsync(id);

            if (receitas == null)
            {
                return NotFound();
            }

            return receitas;
        }

        // PUT: api/ReceitasAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceitas(int id, Receitas receitas)
        {
            if (id != receitas.IDreceita)
            {
                return BadRequest();
            }

            _context.Entry(receitas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReceitasExists(id))
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

        // POST: api/ReceitasAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Receitas>> PostReceitas(Receitas receitas)
        {
            _context.Receitas.Add(receitas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReceitas", new { id = receitas.IDreceita }, receitas);
        }

        // DELETE: api/ReceitasAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceitas(int id)
        {
            var receitas = await _context.Receitas.FindAsync(id);
            if (receitas == null)
            {
                return NotFound();
            }

            _context.Receitas.Remove(receitas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReceitasExists(int id)
        {
            return _context.Receitas.Any(e => e.IDreceita == id);
        }
    }
}
