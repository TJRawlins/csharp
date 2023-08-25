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
            var cmd = new SqlCommand(Order.SqlGetById, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", id); 
            var reader = cmd.ExecuteReader();
            var orders = new List<Order>();
            if (!reader.HasRows)
            {
                reader.Close();
                return null;
            }
            reader.Read();
            var order = CreateOrderFromReader(reader); // moved order properties assignment to method
            reader.Close();
            return order;
        }

        // METHOD - GET ALL ORDERS
        public List<Order> GetAllOrders()
        {
            var cmd = new SqlCommand(Order.SqlGetAll, sqlConnection);
            var reader = cmd.ExecuteReader();
            var orders = new List<Order>();

            while (reader.Read())
            {
                var order = CreateOrderFromReader(reader);
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
            AddSqlParameters(cmd, order);
            var rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected != 1)
            {
                throw new Exception($"Insert Failed! Rows Affected: {rowsAffected}");
            }
        }

        // METHOD - INSERT: GET CUSTOMER ID FROM CODE
        public void InsertOrder(Order order, string customerCode)
        {
            var sql = "SELECT Id FROM Customers WHERE Code = @Code;";
            var cmd = new SqlCommand(@sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Code", customerCode);
            var custId = Convert.ToInt32(cmd.ExecuteScalar());
            order.CustomerId = custId;
            InsertOrder(order);
        }

        // METHOD - UPDATE
        public void UpdateOrder(Order order)
        {
            var sql = "UPDATE Orders SET " +
                " CustomerId = @CustomerId, " +
                " Date = @Date, " +
                " Description = @Description " +
                " WHERE Id = @Id"
                ;
            var cmd = new SqlCommand (sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", order.Id);
            AddSqlParameters(cmd, order); // moved params to a method
            var rowsAffected = cmd.ExecuteNonQuery();
            if(rowsAffected != 1)
            {
                throw new Exception($"Update Failed! Rows Affected: {rowsAffected}");
            }
            Console.WriteLine($"Update Successfull! Rows Affected {rowsAffected}");
        }


        // METHOD - DELETE
        public void DeleteOrder(int id)
        {
            var sql = " DELETE FROM Orders " +
               " WHERE Id = @Id; ";
            var cmd = new SqlCommand(sql, sqlConnection);
            cmd.Parameters.AddWithValue("@Id", id);
            var rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected != 1)
            {
                throw new Exception($"Delete failed! RA is {rowsAffected}");
            }
        }

        // METHOD - ORDER PROP ASSIGNMENT
        private Order CreateOrderFromReader(SqlDataReader reader)
        {
            var order = new Order();
            order.Id = Convert.ToInt32(reader["Id"]);
            order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
            order.Date = Convert.ToDateTime(reader["Date"]);
            order.Description = Convert.ToString(reader["Description"]);
            return order;
        }

        // METHOD - PARAMETER ASSIGNMENT
        private void AddSqlParameters(SqlCommand cmd, Order order)
        {
            cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            cmd.Parameters.AddWithValue("@Date", order.Date);
            cmd.Parameters.AddWithValue("@Description", order.Description);
        }


    }
}
