using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module09.Slide20Full
{
    class Program
    {
        static int EnterTickets()
        {
            string ticketOffice = "Ticket Office NRGi Park";

            int i = 0;
            try
            {
                Console.WriteLine( "Enter the number of desired tickets: " );
                i = int.Parse( Console.ReadLine() );
                Console.WriteLine( "You requested {0} tickets", i );
            }
            catch( OverflowException exception )
            {
                throw new TicketSalesException( "Illegal number of tickets", exception, ticketOffice, DateTime.Now );
            }
            catch( FormatException exception )
            {
                throw new TicketSalesException( "Unspecified number of tickets", exception, ticketOffice, DateTime.Now );
            }

            return i;
        }

        static void Main()
        {
            try
            {
                Console.WriteLine( "{0} tickets was just requested", EnterTickets() );
            }
            catch( TicketSalesException exception )
            {
                Console.WriteLine( exception );

                // This would probably not be printed, but logged!            
                if( exception.InnerException != null )
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine( "\r\nDetailed technical info: {0}", exception.InnerException );
                    Console.ForegroundColor = color;
                }
            }

            Console.ReadLine();
        }
    }
}
