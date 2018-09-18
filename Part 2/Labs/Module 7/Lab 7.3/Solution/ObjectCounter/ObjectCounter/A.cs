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
            get
            {
                lock( typeof( A ) )
                {
                    return _InstanceCount;
                }
            }
        }
        private static int _InstanceCount;

        static A()
        {
            _InstanceCount = 0;
        }

        public A()
        {
            lock( typeof( A ) )
            {
                _InstanceCount++;
            }
        }

        ~A()
        {
            lock( typeof( A ) )
            {
                _InstanceCount--;
            }
        }
    }
}
