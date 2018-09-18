using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXml
{
   class Program
   {
      static void Main( string[] args )
      {
         XDocument doc = XDocument.Load( @"..\..\CustomersOrders.xml" );

         // TODO: Calculate TotalFreight for each customer as the sum
         // of the freight of all orders placed by that customer
      }
   }
}
