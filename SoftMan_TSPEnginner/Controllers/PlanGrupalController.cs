using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftMan_TSPEnginner.Data;
using SoftMan_TSPEnginner.Models;

namespace SoftMan_TSPEnginner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanGrupalController : ControllerBase
    {
        private readonly DataContext _context;

        public PlanGrupalController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PlanGrupal
        [HttpGet]
        public IEnumerable<PlanGrupal> GetPlanGrupal()
        {
            return _context.PlanGrupal;
        }

        // GET: api/PlanGrupal/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlanGrupal(int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //var planGrupal = await _context.PlanGrupal.FindAsync(id);

            //if (planGrupal == null)
            //{
            //    return NotFound();
            //}
            var lista = _context.Tareas.FromSql("select * from dbo.tareas",id).ToList();

            return Ok(lista);
        }

        // PUT: api/PlanGrupal/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanGrupal([FromRoute] int id, [FromBody] PlanGrupal planGrupal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != planGrupal.Id)
            {
                return BadRequest();
            }

            _context.Entry(planGrupal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanGrupalExists(id))
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

        // POST: api/PlanGrupal
        [HttpPost]
        public async Task<IActionResult> PostPlanGrupal([FromBody] PlanGrupal planGrupal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PlanGrupal.Add(planGrupal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanGrupal", new { id = planGrupal.Id }, planGrupal);
        }

        // DELETE: api/PlanGrupal/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanGrupal([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var planGrupal = await _context.PlanGrupal.FindAsync(id);
            if (planGrupal == null)
            {
                return NotFound();
            }

            _context.PlanGrupal.Remove(planGrupal);
            await _context.SaveChangesAsync();

            return Ok(planGrupal);
        }

        private bool PlanGrupalExists(int id)
        {
            return _context.PlanGrupal.Any(e => e.Id == id);
        }
    }
}