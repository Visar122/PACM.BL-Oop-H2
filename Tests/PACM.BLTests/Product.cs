using PACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BLTests
{
  
      public class Product
    {

        public Product() 
        {
            
        }
        public Product(int productId)
        {
            ProductId= productId;
        }
        public decimal ? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

     

        ///summary 
        ///Validates the product data 
        ///</summary> 
        ///<returns> </returns> 
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice==null) isValid = false;
            return isValid;
        }
    }
}
