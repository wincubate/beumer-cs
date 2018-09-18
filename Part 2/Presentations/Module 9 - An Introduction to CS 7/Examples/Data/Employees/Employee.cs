namespace Wincubate.CS7.Data
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        #region Deconstructor

        //public void Deconstruct( out string firstName, out string lastName )
        //{
        //    firstName = FirstName;
        //    lastName = LastName;
        //}

        #endregion
    }
}
