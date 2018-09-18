using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module08.Data
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }

        #region ToString()

        public override string ToString()
        {
            return string.Format("{0} is {1} year{2} old",
                FullName,
                Age,
                (Age == 1 ? "" : "s")
            );
        }

        #endregion

        #region ToJson()

        public JObject ToJson()
        {
            return new JObject
            {
                ["FirstName"] = FirstName,
                ["LastName"] = LastName,
                ["Age"] = Age
            };
        }

        #endregion
    }
}
