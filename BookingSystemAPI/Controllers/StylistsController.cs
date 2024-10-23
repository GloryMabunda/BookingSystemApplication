using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookingAPI.Data;
using BookingAPI.Models;

namespace BookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StylistsController : ControllerBase
    {
        private readonly DataContext _context;

        public StylistsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Stylists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stylist>>> GetStylists()
        {
            return await _context.Stylists.ToListAsync();
        }

        // GET: api/Stylists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stylist>> GetStylist(int id)
        {
            var stylist = await _context.Stylists.FindAsync(id);

            if (stylist == null)
            {
                return NotFound();
            }

            return stylist;
        }

        // POST: api/Stylists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stylist>> PostStylist(Stylist stylist)
        {
            _context.Stylists.Add(stylist);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStylist", new { id = stylist.StylistId }, stylist);
        }

        // DELETE: api/Stylists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStylist(int id)
        {
            var stylist = await _context.Stylists.FindAsync(id);
            if (stylist == null)
            {
                return NotFound();
            }

            _context.Stylists.Remove(stylist);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StylistExists(int id)
        {
            return _context.Stylists.Any(e => e.StylistId == id);
        }
    }
}
