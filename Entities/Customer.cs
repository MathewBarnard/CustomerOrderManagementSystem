using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderManagementSystem.Entities {
    class Customer {

        private int id;
        public int Id {
            set { id = value; }
            get { return id; }
        }

        private string surname { get; set; }
        public string Surname {
            set { surname = value; }
            get { return surname; }
        }

        private string forename { get; set; }
        public string Forename {
            set { forename = value; }
            get { return forename; }
        }

        private string username { get; set; }
        public string Username {
            set { username = value; }
            get { return username; }
        }

        public string FullName {
            get { return forename + " " + surname; }
        }
    }
}
