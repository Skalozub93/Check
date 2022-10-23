using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal struct Choice
    {
        public string someProduct;
        private double price;
        private double count;
        private double discount;
        private ArrayList product;
       

        public Choice(string someProduct = "Анчоусы", double price = 7.5, double count = 4, double discount = 40, ArrayList prod = null)
        {
            this.someProduct = someProduct;
            this.price = price;
            this.count = count;
            this.discount = discount;    
            this.product = prod;
        }
       

        public double Calculation()
        {
            return this.price = count * (price - ((price * discount) / 40));
        }
    }
}
