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

   enum ProductName
   {
      Mælk,
      Smør,
      Brød,
      Øl,
      PepsiMax
   }

   class Program
   {
      static void Main( string[] args )
      {
         var customers = new []
            {
                new 
                {
                    Name = "Kim",
                    City = CustomerCity.Aarhus, 
                    Orders = new [] 
                    { 
                        new
                        {
                            Quantity = 4,
                            Product = new
                            {
                                Name = ProductName.Mælk,
                                Price = 8
                            }
                        },
                        new
                        {
                            Quantity = 2,
                            Product = new
                            {
                                Name = ProductName.Smør,
                                Price = 12
                            }
                        }, 
                        new
                        {
                            Quantity = 2,
                            Product = new
                            { 
                                Name = ProductName.Brød,
                                Price = 22
                            }
                        }
                    } 
                },

                new
                {
                    Name = "Mads",
                    City = CustomerCity.Horsens, 
                    Orders = new []
                    { 
                        new
                        {
                            Quantity = 2,
                            Product = new
                            {
                                Name = ProductName.Mælk,
                                Price = 9
                            }
                        },
                        new
                        {
                            Quantity = 1,
                            Product = new
                            {
                                Name = ProductName.Smør,
                                Price = 12
                            }
                        }, 
                        new
                        {
                            Quantity = 1,
                            Product = new
                            { 
                                Name = ProductName.Brød,
                                Price = 18
                            }
                        },
                        new
                        {
                            Quantity = 6,
                            Product = new
                            {
                                Name = ProductName.Øl,
                                Price = 15
                            }
                        }
                    } 
                },

                new
                {
                    Name = "Jesper",
                    City = CustomerCity.Aarhus, 
                    Orders = new []
                    { 
                        new
                        {
                            Quantity = 12,
                            Product = new
                            {
                                Name = ProductName.PepsiMax,
                                Price = 16
                            }
                        }
                    } 
                }
            };

         foreach( var c in customers )
         {
            Console.WriteLine( c.Name + ", " + c.City );

            foreach( var o in c.Orders )
            {
               Console.WriteLine( "\t{0}x {1} of {2}",
                  o.Quantity,
                  o.Product.Name,
                  o.Product.Price );
            }
         }
      }
   }
}
