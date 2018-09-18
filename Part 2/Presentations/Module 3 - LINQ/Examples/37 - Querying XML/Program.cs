using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wincubate.Module03.Slide37
{
   class Program
   {
      static void Main( string[] args )
      {
         XDocument doc = XDocument.Load( @"C:\Tmp\CustomersOrders.xml" );

         #region Querying

         //var query = ( from order in doc.Descendants( "Order" )
         //              where order.Attribute( "OrderID" ).Value == "10677"
         //              select new
         //              {
         //                 OrderID = (int) order.Attribute( "OrderID" ),
         //                 CustomerID = (string) order.Parent.Attribute( "CustomerID" ),
         //                 Freight = (decimal) order.Attribute( "Freight" )
         //              }
         //            ).FirstOrDefault();

         //Console.WriteLine( "OrderID:{0}\tCustomerID:{1}\tFreight:{2:C}",
         //   query.OrderID,
         //   query.CustomerID, 
         //   query.Freight
         //);

         #endregion

         #region Join

         //string[] orders = { "10707", "10835", "10953" };
         //var query = from order in doc.Descendants( "Order" )
         //            join selected in orders
         //            on order.Attribute( "OrderID" ).Value equals selected
         //            select new
         //            {
         //               OrderID = (int) order.Attribute( "OrderID" ),
         //               CustomerID = order.Parent.Attribute( "CustomerID" ).Value,
         //               Freight = (decimal) order.Attribute( "Freight" )
         //            };

         //foreach ( var order in query )
         //{
         //   Console.WriteLine( "OrderID:{0}\tCustomerID:{1}\tFreight:{2:C}",
         //      order.OrderID,
         //      order.CustomerID, 
         //      order.Freight
         //   );
         //}

         #endregion
      }
   }
}
