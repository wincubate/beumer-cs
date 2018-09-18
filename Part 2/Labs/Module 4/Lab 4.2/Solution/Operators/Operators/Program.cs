using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
   class Program
   {
      static void Main(string[] args)
      {
         Money m1 = new Money(176);
         Money m2 = new Money(9, 115);

         Console.WriteLine("{0}, {1}", m1, m2);

         m1--;
         m2++;
         Console.WriteLine("{0}, {1}", m1, m2);

         Console.WriteLine("m1 is{0}less than m2", m1 < m2 ? " " : " not ");

         m1++;
         Console.WriteLine("{0}, {1}", m1, m2);
         Console.WriteLine("m1 is{0}less than m2", m1 < m2 ? " " : " not ");

         m1 = m1 - 85;
         Console.WriteLine("{0}, {1}", m1, m2);
         Console.WriteLine("m1 is{0}less than m2", m1 < m2 ? " " : " not ");

         m2 -= 123;
         Console.WriteLine("{0}, {1}", m1, m2);

         Console.WriteLine("{0}", m2 - m1);

         int centsInt = 115;
         float centsFloat = 123.45F;

         Money m3 = (Money) centsInt;
         Money m4 = (Money) centsFloat;
         Console.WriteLine("{0}, {1}", m3, m4);

         m3 += 3;
         centsInt = (int) m4;
         centsFloat = m3;
         Console.WriteLine("centsInt : {0}\t\tcentsFloat : {1}",
            centsInt,
            centsFloat );
      }
   }
}
