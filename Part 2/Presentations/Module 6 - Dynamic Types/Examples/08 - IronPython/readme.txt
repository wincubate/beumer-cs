To compile this, you must

1. Install IronPython 2.7 (or later) for .NET 4.0 from http://ironpython.codeplex.com/
2. Add reference to Microsoft.Scripting.dll
   (located in C:\Windows\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Scripting\v4.0_1.1.0.1__31bf3856ad364e35)
3. Add reference to IronPython.dll
   (located in C:\Windows\Microsoft.NET\assembly\GAC_MSIL\IronPython\v4.0_2.7.0.1__31bf3856ad364e35).
4. Add reference to IronPython.Modules.dll
   (located in C:\Windows\Microsoft.NET\assembly\GAC_MSIL\IronPython.Modules\v4.0_2.7.0.1__31bf3856ad364e35).
5. Copy the Python Lib folder contents into the bin\Debug or bin\Release folder of the "09 - IronPython" project , e.g. 
   copy the Lib folder located in: "%PROGRAMFILES%\IronPython 2.7" folder to the current project folder's bin\Debug
