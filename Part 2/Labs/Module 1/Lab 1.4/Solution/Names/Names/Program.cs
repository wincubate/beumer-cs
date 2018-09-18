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
         // Person data
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
         SortedSet<string> set1 = new SortedSet<string>();
         foreach (Person p in persons)
         {
            set1.Add(p.FirstName);
         }

         Console.WriteLine("First name sorted lexicographically:");
         foreach (string firstName in set1)
         {
            Console.WriteLine(firstName);
         }

         Console.WriteLine();

         // TODO 2: Last Names sorted by length (shortest ones first)
         SortedSet<string> set2 = new SortedSet<string>(new LastNameComparer());
         foreach (Person p in persons)
         {
            set2.Add(p.LastName);
         }

         Console.WriteLine("Last Names sorted by length (shortest ones first):");
         foreach (string lastName in set2)
         {
            Console.WriteLine(lastName);
         }

         //
         // Note: The Labs in Module 13 will show a more elegant and compact solution
         //
      }
   }
}
