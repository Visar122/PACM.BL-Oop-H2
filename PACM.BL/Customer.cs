using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace PACM.BL
{
    public class Customer
    {
        public Customer() 
        {
        
        }
        public Customer (int customerID)
        {
            CustomerId= customerID;
        }
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        // auto implemntig property -when you don't need to  check on set and get 
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName +=", ";


                    }
                    fullName+=FirstName;
                }

                return fullName;

            }
        }

        //Private backing field for the public property,lastName 
        //Use this when you want to validate or authenticate 
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;

            }
            set
            {
                _lastName= value;
            }
        }
       

        ///summary 
        ///Validates the costumer data 
        ///</summary> 
        ///<returns> </returns> 
        public bool Validate()
        {
            var isValid = true;
            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress))isValid = false;
            return isValid;
        }


    }
}