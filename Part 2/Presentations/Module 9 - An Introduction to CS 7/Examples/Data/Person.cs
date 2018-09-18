using System;
using System.Collections.Generic;

namespace Wincubate.CS7.Data
{
    public class Person
    {
        private static IDictionary<Guid, string> Names = new Dictionary<Guid, string>();

        private Guid _id = Guid.NewGuid();

        public Person(string name)
        {
            Names.Add(_id, name);
        }

        ~Person()
        {
            Names.Remove(_id);
        }

        public string Name => Names[_id];
    }
}