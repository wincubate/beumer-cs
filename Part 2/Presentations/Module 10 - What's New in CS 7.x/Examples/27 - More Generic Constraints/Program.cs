using System;

namespace Wincubate.CS7x.Slide27
{
    class DelegateWrapper<T> where T : Delegate
    {
        private readonly T _t;
        public DelegateWrapper( T t ) => _t = t;

        public void Invoke( params object[] args ) => _t?.DynamicInvoke(args);
    }

    class Program
    {
        static void Main(string[] args)
        {
            DelegateWrapper<Action<string>> dw = new DelegateWrapper<Action<string>>(Console.WriteLine);
            dw.Invoke("Hello, somewhat-complex-delegate-world");
        }

        unsafe void Hash<T>( T t ) where T : unmanaged
        {
            T* p = &t;

            // Do nasty stuff...
        }
    }
}
