using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wincubate.Module03.Slide38
{
   public class Customer
   {
      public string Id { get; set; }
      public string Name { get; set; }
      public List<Order> Orders { get; set; }
   }
   
   public class Order
   {
      public int Id { get; set; }
      public decimal Freight { get; set; }
   }

   class Program
   {
      static void Main( string[] args )
      {
         XDocument doc = XDocument.Load( @"C:\Tmp\CustomersOrders.xml" );

         #region Transforming XML to objects

         List<Customer> customersOrders =
            ( from c in doc.Descendants( "Customer" )
              select new Customer
              {
                 Id = c.Attribute( "CustomerID" ).Value,
                 Name = c.Attribute( "CompanyName" ).Value,
                 Orders = ( from o in c.Elements( "Order" )
                            select new Order
                            {
                               Id = (int) o.Attribute( "OrderID" ),
                               Freight = (decimal) o.Attribute( "Freight" )
                            } ).ToList()
              } ).ToList();

         foreach ( Customer c in customersOrders )
         {
            Console.WriteLine( "ID:{0}\tName:{1}",
               c.Id, 
               c.Name
            );
            
            foreach( Order o in c.Orders )
            {
               Console.WriteLine( "\tOrderID:{0}\tFreight:{1,7:C}",
                  o.Id, 
                  o.Freight
               );
            }
         }

         #endregion
      }
   }
}
