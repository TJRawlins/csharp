using Microsoft.Data.SqlClient;
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

    }
}
