namespace Wincubate.CS7.Data
{
    public enum ProjectManagerLevel
    {
        AssociateJunior,
        ProjectLead,
        Senior,
        Program
    }

    public class ProjectManager : Employee
    {
        public ProjectManagerLevel? Level { get; set; }
        public string Team { get; set; }
    }
}
