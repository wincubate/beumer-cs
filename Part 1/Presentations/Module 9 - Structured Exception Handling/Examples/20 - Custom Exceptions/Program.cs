using System;

namespace Wincubate.Module09.Slide20
{
    public class TicketSalesException : ApplicationException
    {
        public TicketSalesException() { }
        public TicketSalesException( string message ) : base( message ) { }
        public TicketSalesException( string message, Exception inner ) : base( message, inner ) { }

        public override string Message
        {
            get
            {
                return string.Format( "TicketSales Error Message: {0}", base.Message );
            }
        }
    }

    class Program
    {
        static int EnterTickets()
        {
            int i = 0;
            try
            {
                Console.WriteLine( "Enter the number of desired tickets: " );
                i = int.Parse( Console.ReadLine() );
                Console.WriteLine( "You requested {0} tickets", i );
            }
            catch( OverflowException exception )
            {
                throw new TicketSalesException( "Illegal number of tickets", exception );
            }
            catch( FormatException exception )
            {
                throw new TicketSalesException( "Unspecified number of tickets", exception );
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
                Console.WriteLine( exception.Message );
            }

            Console.ReadLine();
        }
    }
}
