using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoSalaoAPI.Models;

namespace ProjetoSalaoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly ProjetoSalaoAPIContext _context;

        public PessoasController(ProjetoSalaoAPIContext context)
        {
            _context = context;
        }

        // GET: api/Pessoas
        [HttpGet]
        public IEnumerable<Pessoas> GetPessoas()
        {
            return _context.Pessoas;
        }

        // GET: api/Pessoas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPessoas([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pessoas = await _context.Pessoas.FindAsync(id);

            if (pessoas == null)
            {
                return NotFound();
            }

            return Ok(pessoas);
        }

        // PUT: api/Pessoas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoas([FromRoute] int id, [FromBody] Pessoas pessoas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pessoas.Id)
            {
                return BadRequest();
            }

            _context.Entry(pessoas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoasExists(id))
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

        // POST: api/Pessoas
        [HttpPost]
        public async Task<IActionResult> PostPessoas([FromBody] Pessoas pessoas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pessoas.Add(pessoas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPessoas", new { id = pessoas.Id }, pessoas);
        }

        // DELETE: api/Pessoas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoas([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pessoas = await _context.Pessoas.FindAsync(id);
            if (pessoas == null)
            {
                return NotFound();
            }

            _context.Pessoas.Remove(pessoas);
            await _context.SaveChangesAsync();

            return Ok(pessoas);
        }

        private bool PessoasExists(int id)
        {
            return _context.Pessoas.Any(e => e.Id == id);
        }
    }
}