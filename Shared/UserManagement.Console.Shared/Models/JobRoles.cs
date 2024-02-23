namespace UserManagement.Console.Shared.Models
{
    // do same as MenuItem.cs to declare jobroles
    public class JobRoles
    {
        public JobRoles(string jobRoleName, string jobRoleDescription)
        {
            this.JobRoleName = jobRoleName;
            this.JobRoleDescription = jobRoleDescription;
        }

        public string? JobRoleName { get; set; }

        public string? JobRoleDescription { get; set; }

        public override string ToString()
        {
            return $"{this.JobRoleName}: {this.JobRoleDescription}";
        }
    }
}
