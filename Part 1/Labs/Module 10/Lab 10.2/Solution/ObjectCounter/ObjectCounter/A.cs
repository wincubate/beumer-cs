using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectCounter
{
    class A
    {
       public static int InstanceCount
       {
          get;
          private set;
       }

        static A()
        {
            InstanceCount = 0;
        }

        public A()
        {
            InstanceCount++;
        }

        ~A()
        {
            InstanceCount--;
        }
    }
}
