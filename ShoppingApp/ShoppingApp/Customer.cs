using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp
{
    class Customer
    {
        private string name;
        private string size;
        private Clothing[] items;
        public Customer(string name, int measurement)
        {
            this.name = name;
            setSize(measurement);
        }

        // return an array of Clothing item 
        public void addItem(Clothing[] custItems)
        {
            items = custItems;
        }

        public Clothing[] getItems()
        {
            return items;
        }
        public double getTotalClothingCost()
        {
            double total = 0.0;

            for (int i = 0; i < items.Length; i++)
            {
                total = total + items[i].getPrice();

            }
            return total;

        }


        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getSize()
        {
            return size;
        }
        public void setSize(string size)
        {
            this.size = size;
        }

        public void setSize(int measurement)
        {

            switch (measurement)
            {
                case 1:
                case 2:
                case 3:

                    setSize("S");
                    break;
                case 4:
                case 5:
                case 6:
                    setSize("M");
                    break;
                case 7:
                case 8:
                case 9:
                    setSize("L");
                    break;

                default:
                    setSize("X");

                    break;
            }


        }

    }
}
