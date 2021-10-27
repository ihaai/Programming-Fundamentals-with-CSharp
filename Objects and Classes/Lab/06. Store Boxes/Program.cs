using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Store_Boxes
{

    class BoxStore
    {
        public int SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuanitity { get; set; }
        public double ItemPrice { get; set; }
        public double BoxPrice { get; set; }

        public BoxStore(int sn, string itemname, int itemQ, double itemP, double boxP)
        {
            this.SerialNumber = sn;
            this.ItemName = itemname;
            this.ItemQuanitity = itemQ;
            this.ItemPrice = itemP;
            this.BoxPrice = boxP;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<BoxStore> boxStorage = new List<BoxStore>();

            while (true)
            {
                var box = Console.ReadLine().Split().ToList();
                if (box[0].ToLower() == "end")
                {
                    break;
                }

                var serialNumber = int.Parse(box[0]);
                var itemName = box[1];
                var itemQuantity = int.Parse(box[2]);
                var itemPrice = double.Parse(box[3]);
                var boxPrice = itemQuantity * itemPrice;

                boxStorage.Add(new BoxStore(serialNumber, itemName, itemQuantity, itemPrice, boxPrice));
            }

            var filteredBox = boxStorage.OrderByDescending(bp => bp.BoxPrice).ToList();

            foreach(BoxStore bx in filteredBox)
            {
                Console.WriteLine(bx.SerialNumber);
                Console.WriteLine($"-- {bx.ItemName} - ${bx.ItemPrice:f2}: {bx.ItemQuanitity}");
                Console.WriteLine($"-- ${bx.BoxPrice:f2}");
            }
        }
    }
}
