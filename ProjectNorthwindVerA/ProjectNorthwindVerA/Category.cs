//Dom Uzuegbu  
//8/26/22



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNorthwindVerA
{
    internal class Category
    {
        //class variables (instances)
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        //gets and sets
        public int CategoryId
        {   get { return categoryId; }
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
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public string Description
        { get { return description; }
            set { description = value; }
        }


        //Methods

        public override string ToString()
        {
            string message = "";

            message = message + "Category Id:" + this.categoryId;
            message = message + "Category Name:" + this.categoryName;
            message = message + "Description:" + this.description;
            return message;
        }
        
    }
}
