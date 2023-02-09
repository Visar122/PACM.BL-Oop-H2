using PACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BLTests
{
   public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            // Create the instance of the Product class
            // Pass in the requested id 
            Product  product = new Product(productId);

            // Code that retrieves the defined customer 

            // Temporary hard-coded values return 
            // a populated customer 

            if (productId==2)
            {
                product.ProductName="Sunflowers";
                product.ProductDescription="Assorted Size set of 4 Bright Yellow Mini Sunflowers ";
                product.CurrentPrice=15.96M;

            }
            return product;
        }
        public bool Save(Product product)
        {
            // Code that saves the passed in customer 
            return true;
        }
    }
    }
//  Open file Product.cs
//   Delete the save() and Retrieve() methods.

