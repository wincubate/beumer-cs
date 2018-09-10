using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide10NTS
{
    class Button
    {
        public string Caption
        {
            get
            {
                Console.WriteLine( "get;" );
                return _caption;
            }
            set
            {
                Console.WriteLine( "set;" );
                if( value.Length > 10 )
                {
                    _caption = value.Substring( 0, 10 );
                }
                else
                {
                    _caption = value;
                }
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

            button.Caption += " Årh, hvad?!";

            Console.WriteLine( button.Caption );
        }
    }
}
