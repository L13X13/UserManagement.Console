namespace UserManagement.Console.Application.Services
{
    using UserManagement.Console.Shared.Models;

    /// <summary>
    /// The Job Role Service class.
    /// </summary>
    /// <remarks>
    /// All related action to job role will be handled here.
    /// </remarks>
    public class JobRoleService
    {
        private static IEnumerable<JobRoles> listedJobRoles = new List<JobRoles>
            {
                new JobRole { JobroleName = "Technician", JobRoleDescription = "Does technical stuff" },
            };

        // Method to get jobroles
        public static IEnumerable<JobRoles> GetJobRoles()
        {
            return listedJobRoles;
        }

        // method to add a new jobrole
        public static void AddJobRole(JobRoles jobRole)
        {
            listedJobRoles.add(jobRole);

            // new Users { UserFirstName = FirstName, UserLastName = LastName, UserJobRole = JobRole, UserEmail = Email, UserPhoneNumber = PhoneNumber, UserDOB = DOB });
        }

        public IEnumerable<JobRoles> DisplayJobRoles()
        {
            return listedJobRoles;
        }

        // Validate that the job role that the user entered exists
        public string ValidateJobRole(string userJobRole)
        {
            bool roleFound = false;

            foreach (var jobRole in listedJobRoles)
            {
                if (jobRole == userJobRole)
                {
                    roleFound = true;
                }
            }

            if (roleFound == true)
            {
                return "Job Role Validated.";
            }
            else
            {
                return "Role not found, please add it to the list before continuing";
            }

            // RoleFound == true return "Job Role Validated."; : return "Role not found, please add it to the list before continuing";
        }
    }
}