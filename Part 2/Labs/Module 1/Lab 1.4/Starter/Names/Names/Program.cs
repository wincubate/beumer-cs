using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Names
{
   class Program
   {
      static void Main(string[] args)
      {
         // Data
         List<Person> persons = new List<Person>
         {
               #region Names
               new Person ( "Gulmann", "Noah", "Kirk" ),
               new Person ( "Gulmann", "Frederikke", "Kirk" ),
               new Person ( "Gulmann", "Ane", "Kirk" ),
               new Person ( "Henriksen", "Jesper", "Gulmann" ),
               new Person ( "Henriksen", "Jørgen", "Gulmann" ),
               new Person ( "Henriksen", "Annie", "Holmer" ),
               new Person ( "Olsen", "Heidi", "Gulmann" ),
               new Person ( "Madsen", "Jesper" ),
               new Person ( "Olesen", "Lone", "Haudrum" ),
               new Person ( "Madsen", "Andreas", "Haudrum" ),
               new Person ( "Byskov", "Peter" ),
               new Person ( "Vestergaard", "Malene" ),
               new Person ( "Hansen", "Thomas", "Lund" ),
               new Person ( "Kristensen", "Thomas", "Govertz" ),
               new Person ( "Thrane", "Maria" ),
               new Person ( "Grønfeldt", "Mads", "Møller" ),
               new Person ( "Foged", "Kim", "Peter" ),
               new Person ( "Kristensen", "Kim", "Bjørndal" ),
               new Person ( "Kristensen", "Maria", "Bjørndal" )
               #endregion
         };

         // TODO 1: First names sorted lexicographically

         // TODO 2: Last Names sorted by length (shortest ones first)

         //
         // Note: The Labs in Module 13 will show a more elegant and compact solution
         //
      }
   }
}
