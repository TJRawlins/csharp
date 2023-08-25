
using CustomerController;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

/* ---------------------  CREATE CONNECTION ----------------------- */

// CREATE CONNECTION STRING
var connStr = "server=localhost\\sqlexpress;" +
    "database=SalesDb;" +
    "trusted_connection=true;" +
    "trustServerCertificate=true;";

// CREATE INSTANCE OF CONNECTION
var conn = new SqlConnection(connStr);

// OPEN CONNECTION
conn.Open(); 

// CHECK IF OPENED SUCCESSFULLY
if (conn.State != System.Data.ConnectionState.Open)
{
    throw new Exception("Connection did not open!");
}


/* ---------------------  DO STUFF ----------------------- */

// CREATE INSTANCE OF CUSTOMERS CONTROLLER TO CALL METHODS ON
var custCtrl = new CustomersController(conn);


// INSERT CUSTOMER
/*
var newCust = new Customer
{
    Name = "Acme Mfg", 
    City = "Mason",
    State = "OH",
    Sales = 0,
    Active = true
};
custCtrl.InsertCustomer(newCust);
*/

// UPDATE CUSTOMER
/*
Customer? cust1 = custCtrl.GetCustomerById(43);
cust1.Name = "Walmart 1";
custCtrl.UpdateCustomer(cust1);
cust1 = custCtrl.GetCustomerById(43);
Console.WriteLine(cust1);
*/

// GET CUSTOMERS BY ID
/*
Customer? custById = custCtrl.GetCustomerById(10);
Console.WriteLine($"{custById}");
*/

// DELETE ROW
/*
custCtrl.DeleteCustomer(43);
Customer? cust2 = custCtrl.GetCustomerById(43);
if (cust2 == null)
{
    Console.WriteLine("Customer was not found!");
}
else
{
    Console.WriteLine(cust2);    
}
*/

// GET ALL CUSTOMERS
/*
List<Customer> customers = custCtrl.GetAllCustomers();
foreach (var cust in customers)
{
    //Console.WriteLine($"{cust.Id} | {cust.Name}");
    Console.WriteLine($"{cust}");
} 
*/

// GET PARTIAL NAME CUSTOMERS
List<Customer> customers = custCtrl.GetCustomerByPartialName("er");
foreach (var cust in customers)
{
    Console.WriteLine($"{cust}");
}


/* ---------------------  END CONNECTION  ----------------------- */

// CLOSE CONNECTION
conn.Close();