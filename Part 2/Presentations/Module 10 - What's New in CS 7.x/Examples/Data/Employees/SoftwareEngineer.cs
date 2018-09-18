namespace Wincubate.CS7x.Data
{
    public enum SoftwareEngineerLevel
    {
        AssociateJunior,
        Senior,
        Lead,
        Chief
    }

    public class SoftwareEngineer : Employee
    {
        public SoftwareEngineerLevel? Level { get; set; }
        public int CodeLinesProduced { get; set; }
    }
}
