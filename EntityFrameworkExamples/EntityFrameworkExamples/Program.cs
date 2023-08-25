
using EntityFrameworkExamples;
using System.ComponentModel;

// create instance of dBContext (list of available tables)
var _context = new AppDbContect();


/*-------------------------------- CUSTOMERS ------------------------ */

// GET ALL - get everything from the Customers table and put it into a generic list - print each customer in console
/*
var customers = from c in _context.Customers.ToList() select c;
foreach (var cust in customers)
{
    Console.WriteLine(cust);
}
*/


// GET BY ID - get by primary key - can just use the dBContext instance instead of the variable
/*
Console.WriteLine(_context.Customers.Find(1));
*/

// INSERT - Create new Customer instance and insert to table
/*
var newCust = new Customer()
{
    Id = 0,
    Code = "MTT",
    Name = "MAX",
    City = "Mason",
    State = "OH",
    Active = true
};
_context.Customers.Add(newCust); // this gets cached
_context.SaveChanges(); // this actually pushes the cache to the database
*/


// UPDATE - update a customer
/*
var updCustomer = _context.Customers.Find(48);
if (updCustomer == null) return;
updCustomer.Code = "MXTT"; // cached
_context.SaveChanges(); // push to db
 */


// DELETE - delete customer
/*
int id = 48;
var delCust = _context.Customers.Find(id);
if (delCust == null) return; // if null just do nothing and return
_context.Remove(delCust);
_context.SaveChanges(); // this can be done just once, at the end of all your EF commands
*/


/*-------------------------------- ORDERS ------------------------ */

// GET ALL
var orders = _context.Orders.ToList();
orders.ForEach(o => Console.WriteLine(o));

// JOIN - Customers + Orders + OrderLines
var custOrders = from c in _context.Customers
                 join o in _context.Orders
                    on c.Id equals o.CustomerId // customer must be first since it's the first table referenced in the from clause
                 join ol in _context.OrderLines
                    on o.Id equals ol.OrdersId
                 select new
                 {
                     OrderDate = o.Date,
                     o.Description,
                     Customer = c.Name,
                     ol.Product, 
                     ol.Quantity,
                     ol.Price,
                     LineTotal = ol.Quantity * ol.Price
                 };
custOrders.ToList().ForEach(c => Console.WriteLine($"{c.OrderDate} | {c.Description} | {c.Customer} | {c.Customer} | {c.Product} | {c.Quantity} | {c.Price} | {c.LineTotal}"));


