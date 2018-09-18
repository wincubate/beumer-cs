using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module03.Slide20
{
   enum CustomerCity
   {
      Aarhus,
      Horsens
   }

   class Customer
   {
      public int Id
      {
         get;
         set;
      }
      public string Name
      {
         get;
         set;
      }
      public CustomerCity City
      {
         get;
         set;
      }
      public override string ToString()
      {
         return string.Format( "{0}, {1}",
            Name,
            City
         );
      }
   }

   class Order
   {
      public int Id
      {
         get;
         set;
      }
      public int CustomerId
      {
         get;
         set;
      }
      public int Quantity
      {
         get;
         set;
      }
      public Product Product
      {
         get;
         set;
      }

      public override string ToString()
      {
         return string.Format( "{0} x {1}",
            Quantity,
            Product
         );
      }
   }

   enum ProductName
   {
      Mælk,
      Smør,
      Brød,
      Øl,
      PepsiMax
   }

   class Product
   {
      public ProductName Name
      {
         get;
         set;
      }
      public double Price
      {
         get;
         set;
      }

      public override string ToString()
      {
         return string.Format( "{0} á {1:c}",
            Name,
            Price
         );
      }
   }

   class Program
   {
      static void Main( string[] args )
      {
         #region Customers

         List<Customer> customers = new List<Customer>
         {
            new Customer
            {
               Id = 1,
               Name = "Kim",
               City = CustomerCity.Aarhus
            },

            new Customer
            {
               Id = 2,
               Name = "Mads",
               City = CustomerCity.Horsens
            },

            new Customer
            {
               Id = 3,
               Name = "Jesper",
               City = CustomerCity.Aarhus
            }
         };
         #endregion

         #region Orders
         List<Order> orders = new List<Order>
         {
            new Order
            {
               Id = 1,
               CustomerId = 1,
               Quantity = 4,
               Product = new Product
               {
                  Name = ProductName.Mælk,
                  Price = 8
               }
            },
            new Order
            {
               Id = 2,
               CustomerId = 1,
               Quantity = 2,
               Product = new Product
               {
                  Name = ProductName.Smør,
                  Price = 12
               }
            }, 
            new Order
            {
               Id = 3,
               CustomerId = 1,
               Quantity = 2,
               Product = new Product
               { 
                  Name = ProductName.Brød,
                  Price = 22
               }
            },
            new Order
            {
               Id = 4,
               CustomerId = 2,
               Quantity = 2,
               Product = new Product
               {
                  Name = ProductName.Mælk,
                  Price = 9
               }
            },
            new Order
            {
               Id = 5,
               CustomerId = 2,
               Quantity = 1,
               Product = new Product
               {
                  Name = ProductName.Smør,
                  Price = 12
               }
            }, 
            new Order
            {
               Id = 6,
               CustomerId = 2,
               Quantity = 1,
               Product = new Product
               { 
                  Name = ProductName.Brød,
                  Price = 18
               }
            },
            new Order
            {
               Id = 7,
               CustomerId = 2,
               Quantity = 6,
               Product = new Product
               {
                  Name = ProductName.Øl,
                  Price = 15
               }
            },
            new Order
            {
               Id = 8,
               CustomerId = 3,
               Quantity = 12,
               Product = new Product
               {
                  Name = ProductName.PepsiMax,
                  Price = 16
               }
            }         
         };
         #endregion

         var query = from c in customers
                     join o in orders on c.Id equals o.CustomerId
                     select new
                     {
                        Name = c.Name,
                        Product = o.Product
                     };

         foreach ( var cop in query )
         {
            Console.WriteLine( "{0} bought {1}",
               cop.Name,
               cop.Product.Name
            );
         }
      }
   }
}
