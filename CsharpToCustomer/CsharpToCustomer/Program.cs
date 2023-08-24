
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

// RUN METHODS
Customer? custById = custCtrl.GetCustomerById(10);
Console.WriteLine($"{custById}");


List<Customer> customers = custCtrl.GetAllCustomers();
foreach (var cust in customers)
{
    //Console.WriteLine($"{cust.Id} | {cust.Name}");
    Console.WriteLine($"{cust}");
}


/* ---------------------  END CONNECTION  ----------------------- */

// CLOSE CONNECTION
conn.Close();