using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TianLi_WanXiang_Service.Data;
using TianLi_WanXiang_Service.Models;
using Object = TianLi_WanXiang_Service.Models.Object;

namespace TianLi_WanXiang_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectsController : ControllerBase
    {
        private readonly ObjectContext _context;

        public ObjectsController(ObjectContext context)
        {
            _context = context;
        }

        // GET: api/Objects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Object>>> GetObjects()
        {
          if (_context.Objects == null)
          {
              return NotFound();
          }
            return await _context.Objects.ToListAsync();
        }

        // GET: api/Objects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Object>> GetObject(Guid id)
        {
          if (_context.Objects == null)
          {
              return NotFound();
          }
            var @object = await _context.Objects.FindAsync(id);

            if (@object == null)
            {
                return NotFound();
            }

            return @object;
        }

        // PUT: api/Objects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObject(Guid id, Object @object)
        {
            if (id != @object.Id)
            {
                return BadRequest();
            }

            _context.Entry(@object).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjectExists(id))
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

        // POST: api/Objects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Object>> PostObject(Object @object)
        {
          if (_context.Objects == null)
          {
              return Problem("Entity set 'ObjectContext.Objects'  is null.");
          }
            _context.Objects.Add(@object);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObject", new { id = @object.Id }, @object);
        }

        // DELETE: api/Objects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObject(Guid id)
        {
            if (_context.Objects == null)
            {
                return NotFound();
            }
            var @object = await _context.Objects.FindAsync(id);
            if (@object == null)
            {
                return NotFound();
            }

            _context.Objects.Remove(@object);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObjectExists(Guid id)
        {
            return (_context.Objects?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
