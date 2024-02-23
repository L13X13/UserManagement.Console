namespace UserManagement.Console.Shared.Models
{
    public class Users
    {
        public Users(int userId, string userFirstName, string userLastName, string userJobRole, string userEmail, string userPhoneNumber, DateTime userDOB)
        {
            this.UserId = userId;
            this.UserFirstName = userFirstName;
            this.UserLastName = userLastName;
            this.UserJobRole = userJobRole;
            this.UserEmail = userEmail;
            this.UserPhoneNumber = userPhoneNumber;
            this.UserDOB = userDOB;
        }

        public int UserId { get; set; }

        public string? UserFirstName { get; set; }

        public string? UserLastName { get; set; }

        public string? UserJobRole { get; set; }

        public string? UserEmail { get; set; }

        public string? UserPhoneNumber { get; set; }

        public DateTime? UserDOB { get; set; }
    }
}
