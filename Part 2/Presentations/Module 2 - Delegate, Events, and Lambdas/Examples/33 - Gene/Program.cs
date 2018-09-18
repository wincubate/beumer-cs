using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wincubate.Module02.Data;

namespace Wincubate.Module02.Slide33
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manager> managers = new List<Manager>
            {
                new Manager { Name = "Steve Ballmer" },
                new Manager { Name = "Stephen Elop" }
            };

            //List<Employee> employees = managers;
            //employees.Add ( new Developer() );

            //// C# 4.0 Covariance:
            ////  Manager->Employee and
            ////  IEnumerable<Manager> -> IEnumerable<Employee>
            //IEnumerable<Employee> employees = managers;
            //foreach( var e in employees )
            //{
            //   Console.WriteLine( e );
            //}

            //// C# 4.0 Contravariance:
            ////  Manager->Employee and
            ////  IComparable<Manager> <- IComparable<Employee>
            //IComparable<Manager> icm = new Employee(); 
        }
    }
}
