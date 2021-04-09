using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ShoppingApp
{
    class Clothing : IComparable<Clothing>
    {
        private string description;
        private double price;
        private string size;

        public static double MIN_PRICE = 10.0;
        public static double TAX_RATE = 0.2;

        public Clothing()
        {

        }
        public Clothing(string description, double price, string size)
        {
            setDescription(description);
            setPrice(price);
            setSize(size);

        }
        public string getDescription()
        {
            return description;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getSize()
        {
            return size;
        }
        public void setSize(string description)
        {
            this.size = description;
        }
        public double getPrice()
        {
            return price + (price * TAX_RATE);
        }
        public void setPrice(double price)
        {
            this.price = (price > MIN_PRICE) ? price : MIN_PRICE;

        }

        public override String ToString()
        {
            return $" {getDescription()}   | Size: {getSize()} | Price: {getPrice().ToString("C1", CultureInfo.CurrentCulture)}";
        }     

       
        public int CompareTo(Clothing other)
        {
            ///Implement comparable interface in the clothing class to sort clothing objects by their descriptions. 
            ///compare this clothing description to other clothing description
            return this.description.CompareTo(other.description);
        }
    }
}

