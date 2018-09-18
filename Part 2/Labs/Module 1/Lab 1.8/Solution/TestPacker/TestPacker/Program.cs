using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPacker
{
   class Program
   {
      static void Main(string[] args)
      {
         SequencePacker<int> sp = new SequencePacker<int> { 42, 87, 87, 87, 87, 11, 22, 22, 87, 99 };

         foreach (int i in sp)
         {
            Console.WriteLine(i);
         }
      }
   }
}
