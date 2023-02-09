using System;
using PACM.BL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace PACM.BLTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid() {  

        //-- Arrange 

        var customerRepository= new CustomerRepository();
            // Remember, the CustomerDI property is 'private set ',so we use the Constructor to set the customerId
            // We Created an overload constructor to handle just that.

            var expected = new Customer(1)
            {
                EmailAddress="fbaggins@hotmail.me",
                FirstName="Frodo",
                LastName="Baggins"
            };

            // --Act
            var actual = customerRepository.Retrieve(1);
            
            //Assert
            //Notice we cannot use the Assert functionality in the " normal way" .Why? Because ,if we compare the 2 objects, we will be
            // comparing their reference addresses. they are different objectsm hence they will never be the same 
            // We beed another aproach 

            ////Assert.AreEqual(expected,actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
           

        }
    }
}
