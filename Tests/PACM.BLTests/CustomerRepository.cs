using PACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BLTests
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id 
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer 

            // Temporary hard-coded values return 
            // a populated customer 

            if (customerId==1) 
            {
                customer.EmailAddress="fbaggins@hotmail.me";
                customer.FirstName="Frodo";
                customer.LastName="Baggins";

            }
            return customer;
        }
        public bool Save(Customer customer) 
        {
            // Code that saves the passed in customer 
           return true;
        }
    }
}
    
//  Open file Customer.cs
//   Delete the save() and Retrieve() methods.
