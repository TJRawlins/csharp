// Page 245 - Programming SQL In C#

using Microsoft.Data.SqlClient;
using PublicSqlExample;

Console.WriteLine("Hello, World!");

var connStr = "server=localhost\\sqlexpress;" + //connection string
    "database=SalesDb;" +
    "trusted_connection=true;" +
    "trustServerCertificate=true;";

var conn = new SqlConnection(connStr);  //connection Instance

conn.Open();  //Must open immediatly

//testing that the connection is open
if (conn.State != System.Data.ConnectionState.Open)
{
    throw new Exception("Connection didn't open");
}

Console.WriteLine("Success!");

// Use method to get data
var cust15 = GetByPK(15);

/*
//Put our Sql code here
var sql = "SELECT * from Customers Where id = @Id;"; // can use params like "@Id"  DONT USE template literal for this - SQL Injection can happen
var cmd = new SqlCommand(sql, conn); // Instance to package the SQL statement to execute through your connection
cmd.Parameters.AddWithValue("@Id", 10); // define the param
var reader = cmd.ExecuteReader(); // ONLY FOR SELECT call the ExecuteReader, which reads and returns a results set.
                                  // ExecuteNonQuery() is for any data manipulation and retuns int of mods
                                  // ExecuteScalar() returns one row in one column only like an aggregate. Returned object must be converted
var customers = new List<Customer>();

while (reader.Read()) // Read() moves the pointer to the next row and return true if data is found in that row
{
    var cust = new Customer();
    cust.Id = Convert.ToInt32(reader["Id"]); // ["Id"] = column name
    cust.Name = Convert.ToString(reader["Name"]);
    cust.City = Convert.ToString(reader["City"]);
    cust.State = Convert.ToString(reader["State"]);
    cust.Sales = Convert.ToDecimal(reader["Sales"]);
    cust.Active = Convert.ToBoolean(reader["Active"]);
    customers.Add(cust);
    //decimal? sales = reader["Sales"].Equals(DBNull.Value) ? null : Convert.ToDecimal(reader["Sales"]); // check if null
    //Console.WriteLine($"Id={id}, Name={name}");
}

// close data reader because only one data reader can be open at once
reader.Close();
*/

//close the connection when finished so someone else can use it
conn.Close();


// method that returns a Customer instance or null
Customer? GetByPK(int id) {
    var sql = "SELECT * from Customers Where id = @Id;"; // can use params like "@Id". DONT USE template literal for this - SQL Injection can happen
    var cmd = new SqlCommand(sql, conn); // Instance to package the SQL statement to execute through your connection
    cmd.Parameters.AddWithValue("@Id", id); // define the param
    var reader = cmd.ExecuteReader();

    if (!reader.HasRows)
    {
        return null;
    }
    reader.Read();
    var cust = new Customer();
    cust.Id = Convert.ToInt32(reader["Id"]);
    cust.Name = Convert.ToString(reader["Name"]);
    cust.City = Convert.ToString(reader["City"]);
    cust.State = Convert.ToString(reader["State"]);
    cust.Sales = Convert.ToDecimal(reader["Sales"]);
    cust.Active = Convert.ToBoolean(reader["Active"]);

    reader.Close();
    return cust;
}
