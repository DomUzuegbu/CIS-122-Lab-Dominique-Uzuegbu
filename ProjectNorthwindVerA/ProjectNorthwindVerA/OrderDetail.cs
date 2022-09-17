// Dom Uzuegbu
//8/27/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{
    internal class OrderDetail
    {
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = double.MaxValue;
        private int quantity = 0;
        private double discount = 0.0;

        //gets and sets
        public int OrderId
        {   get { return orderId; }
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

        public int ProductId
        {
            get { return productId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = 0;
                }
            }


        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set
            {
                // must be greater than 0.0
                if (value > 0.0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = 0;
                }
            }


        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                // must be greater than 0
                if (value > 0)
                {
                    this.quantity = value;
                }
                else
                {
                    this.quantity = 0;
                }
            }


        }

        public double Discount
        {
            get { return discount; }
            set
            {
                // must be greater than 0.0
                if (value > 0.0)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount = 0;
                }
            }


        }
        //Methods
        public override string ToString()
        {
            string message = "";

            message = message + "Order Id:" + this.orderId;
            message = message + "Product Id:" + this.productId;
            message = message + "Unit Price:" + this.unitPrice;
            message = message + "Quantity:" + this.quantity;
            message = message + "Discount:" + this.discount;
            return message;
        }
    }
}
