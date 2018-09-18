using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module08.Slide10
{
    public class Customer : INotifyPropertyChanged
    {
        #region Properties

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyPropertyChanged( "LastName" );
                NotifyPropertyChanged( "FullName" );
            }
        }
        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyPropertyChanged( "FirstName");
                NotifyPropertyChanged( "FullName" );
            }
        }
        private string _firstName;

        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
                NotifyPropertyChanged( "Company" );
            }
        }
        private string _company;

        #endregion

        #region Constructors

        public Customer()
           : this(
               "Gulmann Henriksen",
               "Jesper",
               "Wincubate")
        {
        }

        public Customer(string lastName, string firstName, string company)           
        {
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }

        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged( string propertyName )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs(propertyName) );
        }

        #endregion
    }
}
