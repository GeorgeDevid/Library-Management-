using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LibraryManagment.Models;

namespace LibraryManagment.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogindetailsController : ControllerBase
    {
        private readonly LibraryContext _context;

        public LogindetailsController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/Logindetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Logindetails>>> GetLogindetails()
        {
            return await _context.Logindetails.ToListAsync();
        }

        // GET: api/Logindetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Logindetails>> GetLogindetails(int id)
        {
            var logindetails = await _context.Logindetails.FindAsync(id);

            if (logindetails == null)
            {
                return NotFound();
            }

            return logindetails;
        }

        // PUT: api/Logindetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLogindetails(int id, Logindetails logindetails)
        {
            if (id != logindetails.LoginId)
            {
                return BadRequest();
            }

            _context.Entry(logindetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LogindetailsExists(id))
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

        // POST: api/Logindetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Logindetails>> PostLogindetails(Logindetails logindetails)
        {
            _context.Logindetails.Add(logindetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLogindetails", new { id = logindetails.LoginId }, logindetails);
        }

        // DELETE: api/Logindetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogindetails(int id)
        {
            var logindetails = await _context.Logindetails.FindAsync(id);
            if (logindetails == null)
            {
                return NotFound();
            }

            _context.Logindetails.Remove(logindetails);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LogindetailsExists(int id)
        {
            return _context.Logindetails.Any(e => e.LoginId == id);
        }
    }
}
