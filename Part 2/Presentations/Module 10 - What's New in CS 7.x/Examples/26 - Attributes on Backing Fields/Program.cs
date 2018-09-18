using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Wincubate.CS7x.Slide26
{
    [Serializable]
    class ShoppingCartItem
    {
        public int ProductId { get; }
        public decimal Price { get; }
        public int Quantity { get; }
        //[field:NonSerialized]
        public decimal Total { get; }

        public ShoppingCartItem( int productID, decimal price, int quantity )
        {
            ProductId = productID;
            Price = price;
            Quantity = quantity;
            Total = price * quantity;
        }
    }

    class Program
    {
        static void Main( string[] args )
        {
            string filename = @"C:\Tmp\Item.bin";
            ShoppingCartItem item = new ShoppingCartItem(1, 19.95M, 2);

            // Serializing
            using (FileStream fs = File.Create(filename))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, item);
            }

            // Deserializing
            ShoppingCartItem retrieved = null;
            using (FileStream fs = File.Open(filename, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                retrieved = formatter.Deserialize(fs) as ShoppingCartItem;
            }

            Console.ReadLine();
        }
    }
}
