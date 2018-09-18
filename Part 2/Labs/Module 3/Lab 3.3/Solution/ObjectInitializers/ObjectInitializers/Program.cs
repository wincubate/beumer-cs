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
         return string.Format("{0}, {1}",
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
         return string.Format("{0} x {1}",
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
         return string.Format("{0} á {1:c}",
            Name,
            Price
         );
      }
   }

   class Program
   {
      static void Main(string[] args)
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

         // TODO 1: The names of all customers having bought milk

         // Keywords-based:
         // var customersHavingBoughtMilk = (from c in customers
         //                                  from o in c.Orders
         //                                  where o.Product.Name == ProductName.Mælk
         //                                  select c.Name).Distinct();

         var customersHavingBoughtMilk = customers
                                             .Where(c => c.Orders.Any(
                                                o => o.Product.Name == ProductName.Mælk
                                               )
                                             );

         foreach (var name in customersHavingBoughtMilk )
         {
            Console.WriteLine(name);
         }

         Console.WriteLine();

         // TODO 2: The total sum spent on orders by all customers together

         // Keywords-based:
         // var sum = (from c in customers
         //            from o in c.Orders
         //            select o.Product.Price * o.Quantity).Sum();

         var sum = customers
                     .SelectMany( c => c.Orders )
                     .Sum( o => o.Product.Price * o.Quantity);

         Console.WriteLine(sum);

         Console.WriteLine();

         // TODO 3: The sum spent by each individual customer

         // Keywords-based:
         // var individualSums = from c in customers
         //                      let value = from order in c.Orders
         //                                  select order.Product.Price * order.Quantity
         //                      select new { Name = c.Name, Sum = value.Sum() };

         var individualSums = customers
                                 .Select(c => new
                                 {
                                    Name = c.Name,
                                    Sum = c.Orders.Sum( o => o.Product.Price * o.Quantity )
                                 });

         foreach (var group in individualSums)
         {
            Console.WriteLine("{0} spent {1}",
               group.Name,
               group.Sum);
         }

         Console.WriteLine();

         // TODO 4: All customers grouped by city

         // Keywords-based:
         // var groupByCity = from c in customers
         //                   group c by c.City;

         var groupByCity = customers.GroupBy(c => c.City);

         foreach (var group in groupByCity)
         {
            Console.WriteLine(group.Key + ": ");

            foreach (var customer in group)
            {
               Console.WriteLine("\t" + customer.Name);
            }
         }
      }
   }
}
