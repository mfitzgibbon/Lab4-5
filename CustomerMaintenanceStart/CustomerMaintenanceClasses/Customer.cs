using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{

    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;

        public Customer()
        {
            this.firstName = "Unknown fName";
            this.lastName = "Unknown lName";
            this.email = "Unknown@email.com";
        }

        public Customer(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string GetDisplayText(string sep)
        {
            return firstName + sep + lastName + sep + email;
        }

        public override string ToString()
        {
            return GetDisplayText("\t");
        }

    }
}
