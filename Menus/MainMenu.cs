using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderManagementSystem.Data_Access_Objects;
using CustomerOrderManagementSystem.Entities;

namespace CustomerOrderManagementSystem.Menus
{
    class MainMenu : Menu
    {
        protected override void Print() {

            Console.Out.Write(
            "###############################\n" +
            "# Please choose an option:    #\n" +
            "###############################\n" +
            "# a) View Orders              #\n" +
            "# b) View Customers           #\n" +
            "###############################\n\n"
            );

            GetUserInput();
        }

        protected override void GetUserInput() {
            // Get user input
            System.IO.TextReader tIn = Console.In;

            string input = tIn.ReadLine();

            // convert to lower case
            input = input.ToLower();


            switch (input) {

                case "a":
                    CustomerDB customerDB = new CustomerDB();
                    Customer customer = customerDB.FindCustomerById(1);
                    Console.WriteLine(customer.Id);
                    Console.WriteLine(customer.FullName);
                    Console.WriteLine(customer.Username);
                    break;
                case "b":
                    Console.Out.WriteLine("Option B chosen");
                    break;
                default:
                    break;
            }
        }
    }
}
