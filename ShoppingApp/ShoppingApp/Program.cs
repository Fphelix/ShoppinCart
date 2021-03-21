using System;

namespace ShoppingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = 0.2;
            double total = 0.0;
            double avg = 0.0;

            Console.WriteLine("Welcome to the Shop  ");

            Customer c1 = new Customer("Pinky", 2);

            Console.WriteLine($"Min Price {Clothing.MIN_PRICE}");


            Clothing item1 = new Clothing("Blue Jacket", 20.9, "M");
            Clothing item2 = new Clothing("Orange T-Shirt", 10.5, "S");


            Clothing[] items = { item1, item2, new Clothing("Green Scarf", 5.0, "S"), new Clothing("Blue-T-Shirt", 10.5, "S") };

            c1.addItem(items);

            Console.WriteLine($"Customer: {c1.getName()} | Size:  {c1.getSize()} | Total Cost: {c1.getTotalClothingCost()}");
            int count = 0;
            double sum = 0.0;

            for (int i = 0; i < c1.getItems().Length; i++)
            {
                Console.WriteLine($"item : {items[i]}");
            }

            for (int i = 0; i < c1.getItems().Length; i++)
            {
                if (items[i].getSize() == "L")
                {
                    count++;
                    sum += items[i].getPrice();
                }
            }

            try
            {
                avg = (count == 0) ? 0 : avg / count;

                avg = sum / count;
                Console.WriteLine($"Average Price : {avg}  {count}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cant diveide by 0");
            }

            Array.Sort(c1.getItems());
        }
    }
}
