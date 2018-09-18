using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Slide28
{
   class Program
   {
      static void Main( string[] args )
      {
         string[] wiiGames =
            {
                "Super Mario Galaxy", 
                "FIFA 09",
                "Guitar Hero III",
                "Wii Sports",
                "Wii Fit",
                "Legend of Zelda: Twilight Princess"
            };
         string[] xbox360Games =
            {
                "Halo", 
                "FIFA 09",
                "Guitar Hero III",
                "Banjo Kazooie"
            };

         
         //foreach ( var g in wiiGames.Union( xbox360Games ).Take( 7 ) )
         //{
         //   Console.WriteLine( g );
         //}

         //foreach ( var g in wiiGames.Union( xbox360Games ).TakeWhile( g => g.Length > 4 ) )
         //{
         //   Console.WriteLine( g );
         //}

         //foreach ( var g in wiiGames.Union( xbox360Games ).Skip( 3 ) )
         //{
         //   Console.WriteLine( g );
         //}

         //foreach ( var g in wiiGames.Union( xbox360Games ).SkipWhile( g => g.Length > 4 ) )
         //{
         //   Console.WriteLine( g );
         //}
      }
   }
}
