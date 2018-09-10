using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide10
{
    class Button
    {
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
            }
        }
        private string _caption;
    }

    class Program
    {
        static void Main()
        {
            Button button = new Button();
            button.Caption = "Click!!";

            //			button.Caption += " Årh, hvad?!";

            Console.WriteLine( button.Caption );
        }
    }
}
