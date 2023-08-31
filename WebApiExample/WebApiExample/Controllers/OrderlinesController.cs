using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiExample.Data;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderlinesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderlinesController(AppDbContext context)
        {
            _context = context;
        }

        private async Task RecalculateOrderTotal(int id)
        {   
            // id is the orderline.orderId
            // get orderline totals
            var total = (from o in _context.Orders
                         join ol in _context.Orderlines
                         on o.Id equals ol.OrderId
                         join i in _context.Items
                         on ol.ItemId equals i.Id
                         where o.Id == id
                         select new
                         {
                             LineTotal = ol.Quantity * i.Price
                         }).Sum(x => x.LineTotal); // get the grand total of all lines
            var order = await _context.Orders.FindAsync(id);
            order!.Total = total;
            await _context.SaveChangesAsync();
            // this will return to whatever calls this method
        }

        // GET: api/Orderlines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orderline>>> GetOrderlines()
        {
          if (_context.Orderlines == null)
          {
              return NotFound();
          }
            return await _context.Orderlines.ToListAsync();
        }

        // GET: api/Orderlines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Orderline>> GetOrderline(int id)
        {
          if (_context.Orderlines == null)
          {
              return NotFound();
          }
            var orderline = await _context.Orderlines.FindAsync(id);

            if (orderline == null)
            {
                return NotFound();
            }

            return orderline;
        }

        // PUT: api/Orderlines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderline(int id, Orderline orderline)
        {
            if (id != orderline.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                await RecalculateOrderTotal(orderline.OrderId);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderlineExists(id))
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

        // POST: api/Orderlines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Orderline>> PostOrderline(Orderline orderline)
        {
          if (_context.Orderlines == null)
          {
              return Problem("Entity set 'AppDbContext.Orderlines'  is null.");
          }
            _context.Orderlines.Add(orderline);
            await _context.SaveChangesAsync();
            // MUST got after the save changes
            await RecalculateOrderTotal(orderline.OrderId);

            return CreatedAtAction("GetOrderline", new { id = orderline.Id }, orderline);
        }

        // DELETE: api/Orderlines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderline(int id)
        {
            if (_context.Orderlines == null)
            {
                return NotFound();
            }
            var orderline = await _context.Orderlines.FindAsync(id);
            if (orderline == null)
            {
                return NotFound();
            }

            // save order id before it gets deleted
            var orderId = orderline.OrderId; 
            _context.Orderlines.Remove(orderline);
            await _context.SaveChangesAsync();
            await RecalculateOrderTotal(orderId);

            return NoContent();
        }

        private bool OrderlineExists(int id)
        {
            return (_context.Orderlines?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
