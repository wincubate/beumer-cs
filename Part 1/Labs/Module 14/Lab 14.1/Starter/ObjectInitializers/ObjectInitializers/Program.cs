using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectInitializers
{
   enum CustomerCity
   {
      Aarhus,
      Horsens
   }

   class Customer
   {
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
      public List<Order> Orders
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
                    Name = "Kim",
                    City = CustomerCity.Aarhus, 
                    Orders = new List<Order> 
                    { 
                        new Order
                        {
                            Quantity = 4,
                            Product = new Product
                            {
                                Name = ProductName.Mælk,
                                Price = 8
                            }
                        },
                        new Order
                        {
                            Quantity = 2,
                            Product = new Product
                            {
                                Name = ProductName.Smør,
                                Price = 12
                            }
                        }, 
                        new Order
                        {
                            Quantity = 2,
                            Product = new Product
                            { 
                                Name = ProductName.Brød,
                                Price = 22
                            }
                        }
                    } 
                },

                new Customer
                {
                    Name = "Mads",
                    City = CustomerCity.Horsens, 
                    Orders = new List<Order>
                    { 
                        new Order
                        {
                            Quantity = 2,
                            Product = new Product
                            {
                                Name = ProductName.Mælk,
                                Price = 9
                            }
                        },
                        new Order
                        {
                            Quantity = 1,
                            Product = new Product
                            {
                                Name = ProductName.Smør,
                                Price = 12
                            }
                        }, 
                        new Order
                        {
                            Quantity = 1,
                            Product = new Product
                            { 
                                Name = ProductName.Brød,
                                Price = 18
                            }
                        },
                        new Order
                        {
                            Quantity = 6,
                            Product = new Product
                            {
                                Name = ProductName.Øl,
                                Price = 15
                            }
                        }
                    } 
                },

                new Customer
                {
                    Name = "Jesper",
                    City = CustomerCity.Aarhus, 
                    Orders = new List<Order>
                    { 
                        new Order
                        {
                            Quantity = 12,
                            Product = new Product
                            {
                                Name = ProductName.PepsiMax,
                                Price = 16
                            }
                        }
                    } 
                }
            };
         #endregion
         
         // TODO 1: All customers name and city

         Console.WriteLine();

         // TODO 2: All customers from Aarhus

         Console.WriteLine();

         // TODO 3: The number of orders placed by Kim
      }
   }
}
