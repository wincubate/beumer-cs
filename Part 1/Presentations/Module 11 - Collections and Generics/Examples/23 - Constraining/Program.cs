using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module11.Slide23
{
    class Program
    {
        static void Swap<T>( ref T a, ref T b ) where T : struct
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void SetNew<T>( ref T a ) where T : new()
        {
            a = new T();
        }

        //class LinkedList<K, V>
        //   where K : struct, IComparable<K>
        //   where V : Car, new()
        //{
        //}

        static void Main( string[] args )
        {
        }
    }
}
