using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module05.Slide13
{
    // This class creates byte arrays to simulate data. 
    public class Data
    {
        private byte[] _data;
        private string _name;

        public Data(int size)
        {
            _data = new byte[size * 1024];
            _name = size.ToString();
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
