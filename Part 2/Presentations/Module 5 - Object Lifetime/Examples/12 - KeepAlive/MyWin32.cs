﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module05.Slide12
{
    // A simple class that exposes two static Win32 functions. 
    // One is a delegate type and the other is an enumerated type. 
    public class MyWin32
    {
        // Declare the SetConsoleCtrlHandler function  
        // as external and receiving a delegate.   
        [DllImport("Kernel32")]
        public static extern bool SetConsoleCtrlHandler(
            HandlerRoutine Handler,
            Boolean Add
        );

        // A delegate type to be used as the handler routine  
        // for SetConsoleCtrlHandler. 
        public delegate bool HandlerRoutine(CtrlTypes CtrlType);

        // An enumerated type for the control messages  
        // sent to the handler routine. 
        public enum CtrlTypes
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT,
            CTRL_CLOSE_EVENT,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT
        }
    }
}
