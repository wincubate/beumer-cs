using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace MondoExpando
{
    class Program
    {
        static void Main( string[] args )
        {
            dynamic contact = new ExpandoObject();
            contact.FirstName = "Jesper";
            contact.LastName = "Gulmann";
            contact.Phone = "22123631";

            contact.Address = new ExpandoObject();
            contact.Address.Street = "Hasselvangen 243";
            contact.Address.ZipCode = "8355";
            contact.Address.City = "Solbjerg";

            Console.WriteLine(
                contact.FirstName + " " + contact.LastName + Environment.NewLine +
                contact.Address.Street + ", " +
                contact.Address.ZipCode + " " +
                contact.Address.City + Environment.NewLine
            );

            #region Removal and Iteration

            //IDictionary<string,object> dict = contact as IDictionary<string,object>;
            //dict.Remove( "FirstName" );
            ////Console.WriteLine( contact.FirstName );

            //foreach( KeyValuePair<string, object> kvp in dict )
            //{
            //    Console.WriteLine( "Property \"{0}\" has the value \"{1}\"",
            //        kvp.Key,
            //        kvp.Value
            //    );
            //}

            #endregion
        }
    }
}
