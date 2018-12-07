using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace PeopleForm
{
    class DataAccess
    {
        public List<Customer> GetCustomers(string firstName) {
            //We need to setup a local scope to automatically connect and disconnect from the server
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                return connection.Query<Customer>("dbo.SelectWithFirstName @FirstName", new { FirstName = firstName}).ToList(); 
            }

        }

        internal void InsertPerson(string first, string last, string email, string phone, string city, string state, string zip)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //
                List<Customer> people = new List<Customer>();
                people.Add(new Customer { FirstName = first, LastName = last, Email = email, Phone = phone, City = city, State = state, Zip = zip });
                connection.Execute("dbo.Customer_Insert @FirstName, @LastName, @Email, @Phone, @City, @State, @Zip", people);
            }
        }
    }
}
