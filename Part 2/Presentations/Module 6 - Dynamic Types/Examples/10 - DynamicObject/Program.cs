using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;

namespace Wincubate.Module06.Slide10
{
    class MyDynamicClass : DynamicObject
    {
        public override bool TryInvokeMember( InvokeMemberBinder binder, object[] args, out object result )
        {
            Console.WriteLine( "You invoked " + binder.Name + "()" );

            result = this;

            return true;
        }
    }


    class Program
    {
        static void Main( string[] args )
        {
            dynamic d = new MyDynamicClass();
            d.SomeDynamicMethod( 42, 87 );

            //MyDynamicClass v = new MyDynamicClass();
            //v.SomeDynamicMethod();
        }
    }
}
