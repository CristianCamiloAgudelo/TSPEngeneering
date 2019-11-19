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
    public class TareaController : ControllerBase
    {
        private readonly DataContext _context;

        public TareaController(DataContext context)
        {
            _context = context;
        }

        //Peticion tipo GET: api/tareas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarea>>> GetTareas()
        {
            return await _context.Tareas.ToListAsync();
        }
        
        //Peticion tipo GET: Un solo registro: api/tarea/4
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarea>> GetTareaItem(int id)
        {
            var tarea = await _context.Tareas.FindAsync(id);   

            if (tarea == null)
            {
                return NotFound();
            }

            return tarea;
        }

        //Peticion de tipo POST: api/tarea
        [HttpPost]
        public async Task<ActionResult<Tarea>> PostTarea(Tarea tarea)
        {
            _context.Tareas.Add(tarea);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTareaItem), new { id = tarea.Id }, tarea);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarea(int id, Tarea tarea)
        {
            if (id != tarea.Id)
            {
                return BadRequest();
            }
            _context.Entry(tarea).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //peticion delete : api/tarea/2
        [HttpDelete("{id}")]
        public async Task<IActionResult>  DeleteTarea(int id)
        {
            var tarea = await _context.Tareas.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }

            _context.Tareas.Remove(tarea);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
