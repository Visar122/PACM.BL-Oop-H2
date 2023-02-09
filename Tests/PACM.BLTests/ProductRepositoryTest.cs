using PACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BLTests
{
    [TestClass()]
    public class ProductRepositoryTest
    {
        [TestMethod()]
        public void RetrieveTests()
        {

            //-- Arrange 

            var productRepository = new ProductRepository();


            var expected = new Product(2)
            {
                CurrentPrice=15.96M,
                ProductDescription="Assorted Size Set of 4 Bright Yellow Mini Sunflowers ",
                ProductName="SunFlowers"
               
            };

            // --Act
            var actual = productRepository.Retrieve(2);

            //Assert
            //Notice we cannot use the Assert functionality in the " normal way" .Why? Because ,if we compare the 2 objects, we will be
            // comparing their reference addresses. they are different objectsm hence they will never be the same 
            // We beed another aproach 

            ////Assert.AreEqual(expected,actual);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
         


        }
    }
}
