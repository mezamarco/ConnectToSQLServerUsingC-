using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleForm
{
    class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }


        public string FullInfo{
            get {
                return $"{FirstName} {LastName}: {Email}\t{Phone}\t{City}\t{State}\t{Zip}"; 
            }
        }


        //Add in more functions to format strings.

    }
}
