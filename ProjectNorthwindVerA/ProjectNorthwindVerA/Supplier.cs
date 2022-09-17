//Dominique Uzuegbu
//8/28/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{

    internal class Supplier
    {
        //Class Variables

        private int supplierId = -1;
        private string companyName = "n/a";     //Blank Defaults
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";
        private string homePage = "n/a";



        //Gets and Sets

        public int SupplierId
        {
            get { return this.supplierId; }
            set { this.supplierId = value; }
        }

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }

        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }

        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
        }
        
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.city = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }
        public string HomePage
        {
            get { return this.homePage; }
            set { this.homePage = value; }
        }

        //Methods

        public override string ToString()
        {
            string message = "";
            message = message + "Supplier Id:" + this.supplierId;
            message = message + "Company Name:" + this.companyName;
            message = message + "Contact Name:" + this.contactName;
            message = message + "Contact Title:" + this.contactTitle;
            message = message + "Address:" + this.address;
            message = message + "City:" + this.city;
            message = message + "Region:" + this.region;
            message = message + "Postal Code:" + this.postalCode;
            message = message + "Country:" + this.country;
            message = message + "Phone:" + this.phone;
            message = message + "Fax:" + this.fax;
            message = message + "Home Page:" + this.homePage;
            return message;
        }
    }
}
