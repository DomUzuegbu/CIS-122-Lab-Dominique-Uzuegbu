//Dom Uzuegbu
//8/26/22


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{
    internal class Employee
    {
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        //Gets and Sets
        public int EmployeeId 
        {
            get { return employeeId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = 0;
                }
            }


        }
        public string LastName
        { get { return lastName; }
          set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { lastName = value; }
        }

        public string Title 
        {   get { return title; }
            set { title = value; }
        }

        public string TitleOfCourtesy
        {
            get { return titleOfCourtesy; }
            set { titleOfCourtesy = value; }
        }

        public string BirthDate
        { get { return birthDate; } 
          set { birthDate = value; } 
        }

        public string HireDate
        { get { return hireDate; }
          set { birthDate = value; }
        }

        public string Address
        {   get { return address; }
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
        {
            get { return country; }
            set { country = value; }
        }

        public string HomePhone
        {   get { return homePhone; }
            set { HomePhone = value; }
        }

        public string Extension 
        { get { return extension; }
          set { extension = value; }
        }

        public string Notes
        { get { return notes; }
          set { notes = value; }
        }

        public int ReportsTo
        {
            get { return reportsTo; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.reportsTo = value;
                }
                else
                {
                    this.reportsTo = 0;
                }
            }


        }

        //Methods

        public override string ToString()
        {
            string message = "";
            message = message + "Employee Id:" + this.employeeId;
            message = message + "Last Name:" + this.lastName;
            message = message + "First Name:" + this.firstName;
            message = message + "Title:" + this.title;
            message = message + "Title of Courtesy:" + this.titleOfCourtesy;
            message = message + "Birth Date:" + this.birthDate;
            message = message + "Hire Date:" + this.hireDate;
            message = message + "Address:" + this.address;
            message = message + "City:" + this.city;
            message = message + "Region:" + this.region;
            message = message + "Postal Code:" + this.postalCode;
            message = message + "Country:" + this.country;
            message = message + "Home Phone:" + this.homePhone;
            message = message + "Extension:" + this.extension;
            return message;
        }
    }
}
