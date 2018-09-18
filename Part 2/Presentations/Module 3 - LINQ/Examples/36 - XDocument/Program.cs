using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wincubate.Module03.Slide36
{
   class Program
   {
      static void Main( string[] args )
      {
         #region Load

         XDocument doc;
         //doc = XDocument.Load( @"C:\Tmp\Movies.xml" );
         
         #endregion

         #region Parse

         string xml = @"
            <CustomersOrders>
               <Customer CustomerID='ALFKI' CompanyName='Alfreds Futterkiste'>
                  <Order OrderID='10643' Freight='29.4600' />
                  <Order OrderID='10692' Freight='61.0200' />
                  <Order OrderID='10702' Freight='23.9400' />
                  <Order OrderID='10835' Freight='69.5300' />
                  <Order OrderID='10952' Freight='40.4200' />
                  <Order OrderID='11011' Freight='1.2100' />
               </Customer>
               <Customer CustomerID='ANATR' CompanyName='Ana Trujillo'>
                  <Order OrderID='10308' Freight='1.6100' />
                  <Order OrderID='10625' Freight='43.9000' />
                  <Order OrderID='10759' Freight='11.9900' />
                  <Order OrderID='10926' Freight='39.9200' />
               </Customer>
               <Customer CustomerID='ANTON' CompanyName='Antonio Moreno'>
                  <Order OrderID='10365' Freight='22.0000' />
                  <Order OrderID='10507' Freight='47.4500' />
                  <Order OrderID='10535' Freight='15.6400' />
                  <Order OrderID='10573' Freight='84.8400' />
                  <Order OrderID='10677' Freight='4.0300' />
                  <Order OrderID='10682' Freight='36.1300' />
                  <Order OrderID='10856' Freight='58.4300' />
               </Customer>
               <Customer CustomerID='AROUT' CompanyName='Around the Horn'>
                  <Order OrderID='10355' Freight='41.9500' />
                  <Order OrderID='10383' Freight='34.2400' />
                  <Order OrderID='10453' Freight='25.3600' />
                  <Order OrderID='10558' Freight='72.9700' />
                  <Order OrderID='10707' Freight='21.7400' />
                  <Order OrderID='10741' Freight='10.9600' />
                  <Order OrderID='10743' Freight='23.7200' />
                  <Order OrderID='10768' Freight='146.3200' />
                  <Order OrderID='10793' Freight='4.5200' />
                  <Order OrderID='10864' Freight='3.0400' />
                  <Order OrderID='10920' Freight='29.6100' />
                  <Order OrderID='10953' Freight='23.7200' />
                  <Order OrderID='11016' Freight='33.8000' />
               </Customer>
            </CustomersOrders>
         ";
         doc = XDocument.Parse( xml );
         
         #endregion

         #region Create

         //doc = new XDocument(
         //   new XElement("CustomersOrders",
         //      new XElement("Customer",
         //         new XAttribute("CustomerID", "ALFKI"),
         //         new XAttribute("CompanyName", "Alfreds Futterkiste"),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10643"),
         //            new XAttribute("Freight", "29.4600")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10692"),
         //            new XAttribute("Freight", "61.0200")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10702"),
         //            new XAttribute("Freight", "23.9400")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10835"),
         //            new XAttribute("Freight", "69.5300")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10952"),
         //            new XAttribute("Freight", "40.4200")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "11011"),
         //            new XAttribute("Freight", "1.2100"))),
         //      new XElement("Customer",
         //         new XAttribute("CustomerID", "ANATR"),
         //         new XAttribute("CompanyName", "Ana Trujillo"),
         //         new XElement("Order",   
         //            new XAttribute("OrderID", "10308"),
         //            new XAttribute("Freight", "1.6100")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10625"),
         //            new XAttribute("Freight", "43.9000")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10759"),
         //            new XAttribute("Freight", "11.9900")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10926"),
         //            new XAttribute("Freight", "39.9200"))),
         //      new XElement("Customer",
         //         new XAttribute("CustomerID", "ANTON"),
         //         new XAttribute("CompanyName", "Antonio Moreno"),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10365"),
         //            new XAttribute("Freight", "22.0000")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10507"),
         //            new XAttribute("Freight", "47.4500")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10535"),
         //            new XAttribute("Freight", "15.6400")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10573"),
         //            new XAttribute("Freight", "84.8400")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10677"),
         //            new XAttribute("Freight", "4.0300")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10682"),
         //            new XAttribute("Freight", "36.1300")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10856"),
         //            new XAttribute("Freight", "58.5300"))),
         //         new XElement("Customer",
         //            new XAttribute("CustomerID", "AROUT"),
         //            new XAttribute("CompanyName", "Around the Horn"),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10355"),
         //            new XAttribute("Freight", "41.9500")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10383"),
         //            new XAttribute("Freight", "34.2400")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10453"),
         //            new XAttribute("Freight", "25.3600")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10558"),
         //            new XAttribute("Freight", "72.9700")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10707"),
         //            new XAttribute("Freight", "21.7400")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10741"),     
         //            new XAttribute("Freight", "10.9600")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10743"),
         //            new XAttribute("Freight", "23.7200")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10768"),
         //            new XAttribute("Freight", "146.3200")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10793"),
         //            new XAttribute("Freight", "4.5200")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10864"),
         //            new XAttribute("Freight", "3.0400")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10920"),
         //            new XAttribute("Freight", "29.6100")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "10953"),
         //            new XAttribute("Freight", "23.7200")),
         //         new XElement("Order",
         //            new XAttribute("OrderID", "11016"),
         //            new XAttribute("Freight", "33.8000")
         //         )
         //      )
         //   )
         //);
         
         #endregion
         
         #region Save

         doc.Save( @"C:\Tmp\CustomersOrders.xml" );

         #endregion
      }
   }
}
