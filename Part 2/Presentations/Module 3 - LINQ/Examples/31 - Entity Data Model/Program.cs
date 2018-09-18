using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module17.Slide09
{
   class Program
   {
      static void Main( string[] args )
      {
         using ( ShopEntities entities = new ShopEntities() )
         {
            //// Create new product
            //Product product = new Product()
            //{
            //   Name = "Free gift",
            //   Price = 0
            //};

            var query = from c in entities.Customers
                        where c.Orders.Count > 0
                        select c;

            foreach ( var c in query )
            {
               Console.WriteLine(
                  string.Format( "{0} {1} has placed {2} orders",
                     c.FirstName,
                     c.LastName,
                     c.Orders.Count )
               );

               //// Give all paying customers a free gift
               //c.Orders.Add( new Order
               //{
               //   Quantity = 1,
               //   Product = product
               //} );
            }

            //entities.SaveChanges();
         }
      }
   }
}
