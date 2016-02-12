using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderManagementSystem.Entities;
using System.Data.SqlClient;
using System.IO;

namespace CustomerOrderManagementSystem.Data_Access_Objects {
    class CustomerDB : ICustomerDAO {

        public void CreateNewCustomer(Customer customer) {
            throw new NotImplementedException();
        }

        public void CreateNewCustomers(List<Customer> customers) {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Customer customer) {
            throw new NotImplementedException();
        }

        public Customer FindCustomerById(int id) {
            SqlConnection conn = DatabaseConnection.GetConnection();

            Customer customer = new Customer();

            try {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction("FindCustomerById");

                string script = File.ReadAllText("Scripts\\GetCustomerById.sql");

                Console.Out.Write(script);

                SqlCommand command = new SqlCommand(script, conn, transaction);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read()) {
                    customer.Id = (int)reader["id"];
                    customer.Surname = (string)reader["surname"];
                    customer.Forename = (string)reader["forename"];
                    customer.Username = (string)reader["username"];
                }
            }
            catch(Exception e) {
                Console.Out.WriteLine(e.ToString());
            }


            return customer;
        }

        public Customer FindCustomersBySurname(string name) {
            throw new NotImplementedException();
        }
    }
}
