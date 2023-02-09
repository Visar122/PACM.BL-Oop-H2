using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BLTests
{
    public class Order
    {
        public Order() 
        {
        
        }
        
        public Order(int orderId)
        {
            OrderID= orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }

        //summary 
        ///Retrive one Order 
        ///</summary>
        ///<param name="OrderId"></param>
        ///<returns> </returns> 
        public Order Retrieve(int orderId)
        {
            //Code that retrieves the defined order 
            return new Order();
        }
        ///summary 
        ///Saves  the  current  order 
        ///</summary> 
        ///<returns> </returns> 
        public bool Save()
        {
            //Code that saves the defined order 

            return true;
        }

        ///summary 
        ///Validates the  order data 
        ///</summary> 
        ///<returns> </returns> 
        public bool Validate()
        {
            var isValid = true;
        
            if (OrderDate==null) isValid = false;
            return isValid;
        }
    }
}
