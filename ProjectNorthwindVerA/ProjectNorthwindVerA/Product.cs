//Written by Dom Uzuegbu
//8/28/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{       
    internal class Product
    {
        //Class Variables

        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = double.MaxValue;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = 0;   //Default = Max int??
        private string discontinued = "n/a";    //Type boolean / Default True or False??

        //Gets and Sets
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

        public string ProductName
        { get { return productName; }
          set { productName = value; }
        }

        public int SupplierId
        {
            get { return supplierId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = 0;
                }
            }


        }

        public int CategoryId
        {
            get { return categoryId; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }


        }

        public string QuantityPerUnit
        { get { return quantityPerUnit; } 
          set { quantityPerUnit = value; } 
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

        public int UnitsInStock
        {
            get { return unitsInStock; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.unitsInStock = value;
                }
                else
                {
                    this.unitsInStock = 0;
                }
            }


        }

        public int UnitsOnOrder
        {
            get { return unitsOnOrder; }
            set
            {
                // must be greater than -1
                if (value > -1)
                {
                    this.unitsOnOrder = value;
                }
                else
                {
                    this.unitsOnOrder = 0;
                }
            }


        }

        public int ReorderLevel
        {
            get { return reorderLevel; }
            set
            {
                // must be greater than 0
                if (value > 0)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = 0;
                }
            }


        }

        public string Discontinued
        { get { return discontinued; }
          set { discontinued = value; }
        }


        //Methods

        public override string ToString()
        {
            string message = "";
            message = message + "Product Id:" + this.productId;
            message = message + "Product Name:" + this.productName;
            message = message + "Supplier Id:" + this.supplierId;
            message = message + "Category Id:" + this.categoryId;
            message = message + "Quantity Per Unit:" + this.quantityPerUnit;
            message = message + "Unit Price:" + this.unitPrice;
            message = message + "Units in Stock:" + this.unitsInStock;
            message = message + "Units on Order:" + this.unitsOnOrder;
            message = message + "Reorder Level:" + this.reorderLevel;
            message = message + "Discontinued:" + this.discontinued;
            return message;
        }
    }
}
