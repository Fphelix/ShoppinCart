using System;
using System.Collections.Generic;
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
            return $"item : {getDescription()}   | Size: {getSize()} | Price: {getPrice()}";
        }


        public int CompareTo(Clothing other)
        {
            return this.description.CompareTo(other.description);

        }
    }
}

