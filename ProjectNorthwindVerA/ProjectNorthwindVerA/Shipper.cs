//Written by Dom U
//8/28/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{
    internal class Shipper
    {
        private int shipperId = -1;
        private string companyName = "n/a"; //Default was blank
        private string phone = "n/a";   //Default was also blank

        //gets and sets
        public int ShipperId
        {
            get { return shipperId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.shipperId = value;
                }
                else
                {
                    this.shipperId = 0;
                }
            }


        }

        public string CompanyName
        { 
          get { return companyName; } 
          set { companyName = value; } 
        }

        public string Phone 
        { 
          get { return phone; } 
          set { phone = value; } 
        }

        //Method

        public override string ToString()
        {
            string message = "";
            message = message + "Shipper Id:" + this.shipperId;
            message = message + "Company Name:" + this.companyName;
            message = message + "Phone:" + this.phone;
            return message;
        }
    }
}
