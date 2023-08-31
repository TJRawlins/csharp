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
    public class OrdersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

    

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
          if (_context.Orders == null)
          {
              return NotFound();
          }
            // this allows you to also get the customer linked to the order
            return await _context.Orders.Include(x => x.Customer).ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
          if (_context.Orders == null)
          {
              return NotFound();
          }
            // this allows you to also get the customer, orderlines, and item linked to the order
            var order = await _context.Orders
                                  .Include(x => x.Customer)
                                  .Include(x => x.Orderlines)!
                                  .ThenInclude(x => x.Item)
                                  .SingleOrDefaultAsync(x => x.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // GET: api/Orders/ok
        [HttpGet("ok")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrdersOk()
        { 
            if (_context.Orders == null)
            {
                return NotFound();
            }

            return await _context.Orders
                                    .Where(x => x.Status == "OK")
                                    .Include(x => x.Customer)
                                    .ToListAsync();
        }


        /* PUT */
        #region
        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // PUT: api/Orders/ok/5
        [HttpPut("ok/{id}")]
        public async Task<IActionResult> SetOrderStatusToOk(int id, Order order)
        {
            order.Status = "OK";
            return await PutOrder(id, order);
        }

        // PUT: api/Orders/bo/5
        [HttpPut("bo/{id}")]
        public async Task<IActionResult> SetOrderStatusToBo(int id, Order order)
        {
            order.Status = "BACKORDER";
            return await PutOrder(id, order);
        }

        // PUT: api/Orders/closed/5
        [HttpPut("closed/{id}")]
        public async Task<IActionResult> SetOrderStatusToClose(int id, Order order)
        {
            order.Status = "CLOSED";
            return await PutOrder(id, order);
        }
        #endregion

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
          if (_context.Orders == null)
          {
              return Problem("Entity set 'AppDbContext.Orders'  is null.");
          }
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            if (_context.Orders == null)
            {
                return NotFound();
            }
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return (_context.Orders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
