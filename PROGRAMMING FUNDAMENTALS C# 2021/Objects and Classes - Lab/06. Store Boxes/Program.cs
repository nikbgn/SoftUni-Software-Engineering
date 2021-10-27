using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Box> items = new List<Box>();
            while (command[0] != "end")
            {
                int serialNumber = int.Parse(command[0]);
                string itemName = command[1];
                int itemQty = int.Parse(command[2]);
                decimal pricePerBox = decimal.Parse(command[3]);
                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = itemName,
                        Price = pricePerBox
                    },
                    ItemQuantity = itemQty,
                    
                    PriceForBox = pricePerBox * itemQty
                };
                items.Add(box);
                command = Console.ReadLine().Split();
            }


            foreach (var box in items.OrderByDescending(x => x.PriceForBox))
            {
                box.PrintBoxInfo();
            }
        }
    }




    class Item
    {

        public string Name { get; set; }

        public decimal Price { get; set; }
    }



    class Box
    {

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForBox { get; set; }


        public void PrintBoxInfo()
        {
            
            Console.WriteLine($"{SerialNumber}\n-- {Item.Name} - ${Item.Price:f2}: {ItemQuantity}\n-- ${PriceForBox:f2}");
        }
    }
}
