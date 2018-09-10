using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module08.Slide19
{
    class Employee
    {
        public string Name { get; protected set; }
        private float _currentPay;

        public Employee( string name, float currentPay )
        {
            Name = name;
            _currentPay = currentPay;
        }

        public virtual void GiveBonus( float amount )
        {
            _currentPay += amount;
        }

        public void PrintPay()
        {
            Console.WriteLine( string.Format( "{0} gets {1}",
               Name,
               _currentPay )
            );
        }
    }

    class Manager : Employee
    {
        public int NumberOfOptions { get; protected set; }

        public Manager( string name, float currentPay, int numberOfOptions )
            : base( name, currentPay )
        {
            NumberOfOptions = numberOfOptions;
        }

        public override void GiveBonus( float amount )
        {
            base.GiveBonus( amount );

            Random r = new Random();
            NumberOfOptions += r.Next( 500 );
        }
    }


    class SalesPerson : Employee
    {
        public int NumberOfSales { get; protected set; }

        public SalesPerson( string name, float currentPay, int numberOfSales )
            : base( name, currentPay )
        {
            NumberOfSales = numberOfSales;
        }

        public override void GiveBonus( float amount )
        {
            int salesBonus = 0;

            if( 0 <= NumberOfSales && NumberOfSales <= 100 )
            {
                salesBonus = 10;
            }
            else if( 101 <= NumberOfSales && NumberOfSales <= 200 )
            {
                salesBonus = 15;
            }
            else
            {
                salesBonus = 20;
            }

            base.GiveBonus( amount * salesBonus );
        }
    }

    class FreelanceSalesman : SalesPerson
    {
        public int HoursWorked { get; protected set; }

        public FreelanceSalesman( string name, float currentPay, int numberOfSales, int hoursWorked )
            : base( name, currentPay, numberOfSales )
        {
            HoursWorked = hoursWorked;
        }

        public override void GiveBonus( float amount )
        {
            base.GiveBonus( amount + HoursWorked * 2 );
        }
    }

    class Program
    {
        static void Main()
        {
            Manager manager = new Manager( "Angry Bob", 900000, 1000 );
            manager.PrintPay();
            manager.GiveBonus( 5000 );
            manager.PrintPay();

            SalesPerson salesPerson = new SalesPerson( "Chatty Charles", 500000, 2 );
            salesPerson.PrintPay();
            salesPerson.GiveBonus( 5000 );
            salesPerson.PrintPay();
        }
    }
}
