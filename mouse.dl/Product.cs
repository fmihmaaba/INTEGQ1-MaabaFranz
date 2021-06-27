using System;
using System.Collections.Generic;
using System.Text;

namespace mouse.dl
{
    public class Product
    {
        public string mouseBrand;
        private string price;
        private DateTime date;

        public Product(string mouseBrand, string price, DateTime date)
        {
            this.mouseBrand = mouseBrand;
            this.price = price;
            this.date = date;


        }


        public string MouseBrand
        {
            get { return mouseBrand; }
            set { mouseBrand = value; }
        }


        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }
}
