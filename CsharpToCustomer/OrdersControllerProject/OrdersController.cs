using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OrderController
{
    public class OrdersController
    {
        public SqlConnection sqlConnection { get; set; }

        public OrdersController(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        // METHOD - GET BY ID
        public Order? GetOrderById(int id)
        {
            if (id < 0) 
            {
                throw new ArgumentException("Invalid Id");
            }
            var sql = "SELECT * FROM Orders Where Id = @Id";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", id);
            var reader = cmd.ExecuteReader();
            var orders = new List<Order>();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var order = new Order();
            order.Id = Convert.ToInt32(reader["Id"]);
            order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
            order.Date = Convert.ToDateTime((DateTime)reader["Date"]);
            order.Description = Convert.ToString(reader["Description"]);
            reader.Close();
            return order;
        }

        // METHOD - GET ALL ORDERS
        public List<Order> GetAllOrders()
        {
            var sql = "SELECT * FROM Orders";
            var cmd = new SqlCommand(sql, sqlConnection);
            var reader = cmd.ExecuteReader();
            var orders = new List<Order>();

            while (reader.Read())
            {
                var order = new Order();
                order.Id = Convert.ToInt32(reader["Id"]);
                order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                order.Date = Convert.ToDateTime((DateTime)reader["Date"]);
                order.Description = Convert.ToString((string)reader["Description"]);
                orders.Add(order);
            }
            reader.Close();
            return orders;
        }

        // METHOD - INSERT
        public void InsertOrder(Order order)
        {
            var sql = " INSERT Orders " +
                " (CustomerId, Date, Description) VALUES " +
                " (@CustomerId, @Date, @Description); ";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            cmd.Parameters.AddWithValue("@Date", order.Date);
            cmd.Parameters.AddWithValue("@Description", order.Description);
            var rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected != 1)
            {
                throw new Exception($"Insert Failed! Rows Affected: {rowsAffected}");
            }
            Console.WriteLine($"Rows Affected: {rowsAffected}");
        }

        // METHOD - UPDATE
        public void UpdateOrder(Order order)
        {
            var sql = "UPDATE Orders SET " +
                " CustomerId = @CustomerId " +
                " Date = @Date " +
                " Description = @Description " +
                " WHERE Id = @Id"
                ;
            var cmd = new SqlCommand (sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", order.Id);
            cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            cmd.Parameters.AddWithValue("@Date", order.Date);
            cmd.Parameters.AddWithValue("@Description", order.Description);
            var rowsAffected = cmd.ExecuteNonQuery();
            if(rowsAffected != 1)
            {
                throw new Exception($"Update Failed! Rows Affected: {rowsAffected}");
            }
            Console.WriteLine($"Update Successfull! Rows Affected {rowsAffected}");
        }

        // METHOD - DELTE
        public void DeleteOrder()
        {

        }


    }
}
