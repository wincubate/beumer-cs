using System;
using System.Threading;

namespace Wincubate.Module05.Slide12
{
    public class Program
    {
        #region Handler Method

        // A private static handler function in the MyApp class. 
        static bool MyHandlerMethod(MyWin32.CtrlTypes CtrlType)
        {
            string message = "This message should never be seen!";

            // A switch to handle the event type. 
            switch (CtrlType)
            {
                case MyWin32.CtrlTypes.CTRL_C_EVENT:
                    message = "A CTRL_C_EVENT was raised by the user.";
                    break;
                case MyWin32.CtrlTypes.CTRL_BREAK_EVENT:
                    message = "A CTRL_BREAK_EVENT was raised by the user.";
                    break;
                case MyWin32.CtrlTypes.CTRL_CLOSE_EVENT:
                    message = "A CTRL_CLOSE_EVENT was raised by the user.";
                    break;
                case MyWin32.CtrlTypes.CTRL_LOGOFF_EVENT:
                    message = "A CTRL_LOGOFF_EVENT was raised by the user.";
                    break;
                case MyWin32.CtrlTypes.CTRL_SHUTDOWN_EVENT:
                    message = "A CTRL_SHUTDOWN_EVENT was raised by the user.";
                    break;
            }

            // Use interop to display a message for the type of event.
            Console.WriteLine(message);

            return true;
        }

        #endregion

        public static void Main()
        {
            // Use interop to set a console control handler.
            MyWin32.HandlerRoutine hr = new MyWin32.HandlerRoutine(MyHandlerMethod);
            MyWin32.SetConsoleCtrlHandler(hr, true);

            // Give the user some time to raise a few events.
            Console.WriteLine("Waiting 30 seconds for console ctrl events...");

            // The object hr is not referred to again. 
            // The garbage collector can detect that the object has no 
            // more managed references and might clean it up here while 
            // the unmanaged SetConsoleCtrlHandler method is still using it.       

            // Force a garbage collection to demonstrate how the hr 
            // object will be handled.
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            Thread.Sleep(30000);

            // Display a message to the console when the unmanaged method 
            // has finished its work.
            Console.WriteLine("Finished!");

            // Call GC.KeepAlive(hr) at this point to maintain a reference to hr.  
            // This will prevent the garbage collector from collecting the  
            // object during the execution of the SetConsoleCtrlHandler method.
            GC.KeepAlive(hr);
            Console.Read();
        }
    }
}
