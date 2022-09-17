//Dom Uzuegbu
//8/27/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{
    //Privaate classes For Order
    internal class Order
    {
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "n/a";
        private string requireDate = "n/a";
        private string shippedDate = "n/a";
        private int shipVia = -1;
        private double freight = double.MaxValue;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";

        //gets and sets

        public int OrderId
        {
            get { return orderId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.orderId = value;
                }
                else
                {
                    this.orderId = 0;
                }
            }


        }

        public string CustomerId
        { get { return customerId; } 
          set { customerId = value; }
        }

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

        public string OrderDate
        { get { return orderDate; }
          set { orderDate = value; }
        }

        public string RequiredDate
        { get { return requireDate; } 
          set { requireDate = value; } 
        }

        public string ShippedDate
        { get { return shippedDate; }
          set { shippedDate = value; }
        }

        public int ShipVia
        {
            get { return shipVia; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.shipVia = value;
                }
                else
                {
                    this.shipVia = 0;
                }
            }


        }

        public double Freight
        {
            get { return freight; }
            set
            {
                // must be greater than 0.0
                if (value > 0.0)
                {
                    this.freight = value;
                }
                else
                {
                    this.freight = 0;
                }
            }


        }

        public string ShipName
        { get { return shipName; }
          set { shipName = value; }
        }

        public string ShipAddress
        {   get { return shipAddress; }
            set { shipAddress = value; }
        }

        public string ShipCity
        { get { return shipCity; } 
          set { shipCity = value; } 
        }

        public string ShipRegion
        { get { return shipRegion; }
          set { shipRegion = value; }
        }

        public string ShipPostalCode
        { get { return shipPostalCode; }
          set { shipPostalCode = value; }
        }

        public string ShipCountry
        { get { return shipCountry; }
          set { shipCountry = value; }
        }

        //Method

        public override string ToString()
        {
            string message = "";
            message = message + "Order Id:" + this.orderId;
            message = message + "Customer Id:" + this.customerId;
            message = message + "Employee Id:" + this.employeeId;
            message = message + "Order Date:" + this.orderDate;
            message = message + "Require Date:" + this.requireDate;
            message = message + "Shipped Date:" + this.shippedDate;
            message = message + "Ship Via:" + this.shipVia;
            message = message + "Freight:" + this.freight;
            message = message + "Ship Name:" + this.shipName;
            message = message + "Ship Address:" + this.shipAddress;
            message = message + "Ship City:" + this.shipCity;
            message = message + "Ship Region:" + this.shipRegion;
            message = message + "Ship Postal Code:" + this.shipPostalCode;
            message = message + "Ship Country:" + this.shipCountry;
            return message;
        }


    }
}
