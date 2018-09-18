using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace Wincubate.Module06.Slide11
{
    class Program
    {
        static void Main( string[] args )
        {
            dynamic contact = new ExpandoObject();
            contact.FirstName = "Jesper";
            contact.LastName = "Gulmann";
            contact.Phone = "22123631";

            Console.WriteLine( contact.FirstName + " " + contact.LastName );

            //contact.Address = new ExpandoObject();
            //contact.Address.Street = "Hasselvangen 243";
            //contact.Address.ZipCode = "8355";
            //contact.Address.City = "Solbjerg";

            //Console.WriteLine( 
            //    contact.Address.Street + ", " +
            //    contact.Address.ZipCode + " " +
            //    contact.Address.City 
            //);
        }
    }
}
