using System;
using System.Globalization;

namespace ShoppingApp
{
    class Program
    {

    

        static void Main(string[] args)
        {
            double tax = 0.2;
            double total = 0.0;
            double avg = 0.0;

            Console.WriteLine("Welcome to My mini Shop  ");

            Customer c1 = new Customer("Pinky", 2);
           
           
           // Console.WriteLine($"Min Price {Clothing.MIN_PRICE.ToString("C1", CultureInfo.CurrentCulture)}");


            Clothing item1 = new Clothing("Blue Jacket", 20.9, "M");
            Clothing item2 = new Clothing("Orange T-Shirt", 10.5, "S");

            

            Clothing[] items = { item1, item2, new Clothing("Green Scarf", 5.0, "S"), new Clothing("Blue-T-Shirt", 10.5, "S") };

            c1.addItem(items);  ///To add new items to the current array 
            

            /// Displays customer c1(Pinky) size and total purchase 

            Console.WriteLine($"Customer: {c1.getName()} | Size:  {c1.getSize()} | Total Cost: {c1.getTotalClothingCost().ToString("C1", CultureInfo.CurrentCulture)}");
          
            int count = 0;
            double sum = 0.0;

           
            int countitemNumber = 1;
            for (int i = 0; i < c1.getItems().Length; i++)                    
            {
                /// Prints detail of individual clothing objects . This is calling
                /// the ToString Method in the Clothing class.
                Array.Sort(c1.getItems());
                Console.WriteLine($"item {countitemNumber++} : {items[i]}");
            }

            
          
          
           
            for (int i = 0; i < c1.getItems().Length; i++)
            {
               ///<summary> Calculate average price for all clothing items of size "L" owned by the customer.
               ///using a try-catch to intercept cannot divide by 0 exception in case customer
               ///didn't order anything of size L for example</summary>
               
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

        }
    }
}
