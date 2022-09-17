//Dom Uzuegbu
//8/26/22



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{
    internal class Customer
    {//class variables and default values 
        private string customerId = "n/a";  //"n/a" is a placeholder
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        //gets and sets again
        public string CustomerId
        { get { return customerId; }
          set { customerId = value; }
        }

        public string CompanyName
        { get { return companyName; }
          set { companyName = value; }
        }

        public string ContactName
        { get { return contactName; }
          set { contactName = value; }
        }

        public string ContactTitle
        { get { return contactTitle; }
          set { contactTitle = value; }
        }

        public string Address
        { get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Region
        { get { return region; }
          set { region = value; }
        }

        public string PostalCode
        { get { return postalCode; }
          set { postalCode = value; }
        }

        public string Country
        { get { return country; }
            set { country = value; }
        }

        public string Phone
        { get { return phone; }
            set { phone = value; }
        }

        public string Fax
        { get { return fax; }
          set { fax = value; }
        }

        //Methods

        public override string ToString()
        {
            string message = "";

            message = message + "Customer Id:" + this.customerId;
            message = message + "Customer Name:" + this.companyName;
            message = message + "Contact Name:" + this.contactName;
            message = message + "Contact Title:" + this.contactTitle;
            message = message + "Address:" + this.address;
            message = message + "City:" + this.city;
            message = message + "Region:" + this.region;
            message = message + "Postal Code:" + this.postalCode;
            message = message + "Country:" + this.country;
            message = message + "Phone:" + this.phone;
            message = message + "Fax:" + this.fax;
            return message;
        }





    }
}
