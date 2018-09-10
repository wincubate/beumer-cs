using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    public static class Singleton<T> where T : class, new()
    {
        private static T _instance = null;

        public static T Instance
        {
            get
            {
                if( _instance == null )
                {
                    _instance = new T();
                }
                return _instance;
            }
        }
    }
}
