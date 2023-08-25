using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlTypes;

namespace CustomerController
{
    public class CustomersController
    {
        // CREATE SQL CONNECTION PROPERTY
        public SqlConnection sqlConnection { get; set; }

        // CREATE CONSTRUCTOR "THIS" REFERS TO THE CONNECTION PROPERTY
        public CustomersController(SqlConnection sqlConnection)
        {
             this.sqlConnection = sqlConnection;
        }

        // METHOD - GET BY ID
        public Customer? GetCustomerById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("'id' must be greater than zero");
            }
            var sql = "SELECT * FROM Customers Where Id = @Id";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", id);
            var reader = cmd.ExecuteReader();
            var customers = new List<Customer>();
            if (!reader.HasRows)
            {
                reader.Close();
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

        // METHOD - GET BY PARTIAL NAME
        public List<Customer> GetCustomerByPartialName(string Name)
        {
            if (Name == null)
            {
                throw new ArgumentException("'Name' must have a value");
            }
            var sql = "SELECT * FROM Customers WHERE Name LIKE '%'+@Name+'%' ORDER BY Sales DESC";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Name", Name);
            var reader = cmd.ExecuteReader();
            var customers = new List<Customer>();
            while (reader.Read())
            {
                var cust = new Customer();
                cust.Id = Convert.ToInt32(reader["id"]);
                cust.Name = Convert.ToString(reader["Name"]);
                cust.City = Convert.ToString(reader["City"]);
                cust.State = Convert.ToString(reader["State"]);
                cust.Sales = Convert.ToDecimal(reader["Sales"]);
                cust.Active = Convert.ToBoolean(reader["Active"]);
                customers.Add(cust);
            }

            reader.Close();
            return customers;
        }

        // METHOD - GET ALL CUSTOMERS USING LIST
        public List<Customer> GetAllCustomers()
        {
            var sql = "SELECT * FROM Customers";
            var cmd = new SqlCommand(sql, sqlConnection);
            var reader = cmd.ExecuteReader();
            var customers = new List<Customer>();
            while (reader.Read())
            {
               var cust = new Customer();
               cust.Id = Convert.ToInt32(reader["id"]);
               cust.Name = Convert.ToString(reader["Name"]);
               cust.City = Convert.ToString(reader["City"]);
               cust.State = Convert.ToString(reader["State"]);
               cust.Sales = Convert.ToDecimal(reader["Sales"]);
               cust.Active = Convert.ToBoolean(reader["Active"]);
               customers.Add(cust);
            }
            reader.Close();
            return customers;
        }

        // METHOD - INSERT
        public void InsertCustomer(Customer customer)
        {
            var sql = " INSERT Customers " + 
                "(Name, City, State, Sales, Active) VALUES " +
                "(@Name, @City, @State, @Sales, @Active);";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@City", customer.City);
            cmd.Parameters.AddWithValue("@State", customer.State);
            cmd.Parameters.AddWithValue("@Sales", customer.Sales);
            cmd.Parameters.AddWithValue("@Active", customer.Active);
            var rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected != 1) {
                throw new Exception($"Insert failed! RA is {rowsAffected}");
            }
            Console.WriteLine($"Rows affected is {rowsAffected}");
        }

        // METHOD - UPDATE
        public void UpdateCustomer(Customer customer)
        {
            var sql = " UPDATE Customers SET " +
                " Name = @Name, " +
                " City = @City, " +
                " State = @State, " +
                " Sales = @Sales, " +
                " Active = @Active " +
                " WHERE Id = @Id; ";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", customer.Id);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@City", customer.City);
            cmd.Parameters.AddWithValue("@State", customer.State);
            cmd.Parameters.AddWithValue("@Sales", customer.Sales);
            cmd.Parameters.AddWithValue("@Active", customer.Active);
            var rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected != 1)
            {
                throw new Exception($"Update failed! RA is {rowsAffected}");
            }
        }

        // METHOD - DELETE
        public void DeleteCustomer(int id)
        {
            var sql = " DELETE FROM Customers " +
               " WHERE Id = @Id; ";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", id);
            var rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected != 1)
            {
                throw new Exception($"Delete failed! RA is {rowsAffected}");
            }
        }
    }
}