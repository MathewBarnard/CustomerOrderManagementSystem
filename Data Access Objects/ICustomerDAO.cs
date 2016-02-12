using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderManagementSystem.Entities;

namespace CustomerOrderManagementSystem.Data_Access_Objects {
    interface ICustomerDAO {

        // CREATE
        void CreateNewCustomer(Customer customer);
        void CreateNewCustomers(List<Customer> customers);

        // READ
        Customer FindCustomerById(int id);
        Customer FindCustomersBySurname(string name);

        // UPDATE

        // DELETE
        void DeleteCustomer(Customer customer);

    }
}
