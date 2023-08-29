
using EntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

var _context = new SalesContext();

/*
var orders = from o in _context.Orders
             join ol in _context.Orderlines
                on o.Id equals ol.OrderId
             join i in _context.Items
                on ol.ItemId equals i.Id
             select new
             {
                 Order = o.Id,
                 o.Description,
                 Product = i.Name,
                 ol.Quantity,
                 i.Price,
                 LineTotal = ol.Quantity * i.Price
             };
*/

var orders = _context.Orders.
                            Include(x => x.Orderlines)
                            .ThenInclude(x => x.Item)
                            .Where(x => x.Id == 1);


/*
foreach (var item in orders.ToList() )
{
    Console.WriteLine($"{item.Order} | {item.Description} | {item.Product} | {item.Quantity} | {item.Price} | {item.LineTotal}");
}
*/