using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderManagementSystem.Menus {
    abstract class Menu {

        // An example of the Template Method pattern. Every menu will Print to the console, and then expect input from the user.
        public void Show() {
            Print();
            GetUserInput();
        }

        protected abstract void Print();
        protected abstract void GetUserInput();
    }
}
