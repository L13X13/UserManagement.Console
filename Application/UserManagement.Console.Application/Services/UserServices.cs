public static IEnumerable<User> GetUsers()
{
    return listedUsers;
}

public static GetUserById(int userId)
{
    return from user in listedUsers
           where user.UserId == userId
           select user.FirstOrDefault();
}

// Method to get users
// Allow the user to input information for a new user and add it to the system.
public void AddNewUser(Users user)
{
    listedUsers.Add(user);

    // new Users { UserFirstName = FirstName, UserLastName = LastName, UserJobRole = JobRole, UserEmail = Email, UserPhoneNumber = PhoneNumber, UserDOB = DOB });
}

// Show a summary of information for all users currently in the system, including their job roles.
public static void DisplayAllUsers()
{
    GetUsers();
}

public static void SearchUserId(int userId)
{
    GetUserById(userId);
}

// Allow the user to update information for an existing user, including their job roles.
public static string UpdateUser(User user, int userId, int updateChoice, string changedName, string changedLastname, string changedEmail, string changedPhoneNumber, string changedJobRole, DateTime changedDOB)
{
    switch (UpdateChoice)
    {
        case 1:
            GetUserById(userId);
            if (user != null)
            {
                user.UserFirstName = ChangedName;
                return $"User's first name has been updated to {ChangedName}";
            }
            else
            {
                Console.WriteLine("User not found.");
            }

            break;

        case 2:
            GetUserById(userId);
            if (user != null)
            {
                user.UserLastName = ChangedLastname;
                return $"User's last name has been updated to {ChangedLastname}";
            }
            else
            {
                Console.WriteLine("User not found.");
            }

            break;

        case 3:
            GetUserById(userId);
            if (user != null)
            {
                user.UserLastName = ChangedJobRole;
                return $"User's job role has been updated to {ChangedJobRole}";
            }
            else
            {
                Console.WriteLine("User not found.");
            }

            break;

        case 4:
            GetUserById(userId);
            if (user != null)
            {
                user.UserLastName = ChangedEmail;
                return $"User's email has been updated to {ChangedEmail}";
            }
            else
            {
                Console.WriteLine("User not found.");
            }

            break;

        case 5:
            GetUserById(userId);
            if (user != null)
            {
                user.UserLastName = ChangedPhoneNumber;
                return $"User's phone number has been updated to {ChangedPhoneNumber}";
            }
            else
            {
                Console.WriteLine("User not found.");
            }

            break;

        case 6:
            GetUserById(userId);
            if (user != null)
            {
                user.UserLastName = ChangedDOB;
                return $"User date of birth is updated to {ChangedDOB}";
            }
            else
            {
                Console.WriteLine("User not found.");
            }

            break;

        default:
            return "Please enter one of the available choices";
    }
}

// Allow the user to remove a user from the system.
public static void DeleteUserById(Users user, int userId)
{
    ListedUsers.RemoveAll(user => user.userId == user);
}
namespace UserManagement.Console.Application.Services
{
    using System.Security.Cryptography.X509Certificates;
    using System.Text.RegularExpressions;
    using UserManagement.Console.Shared.Models;

    public class UserServices
    {
        public IEnumerable<Users> ListedUsers = new List<Users>()
            {
                new User { UserId = 1, UserFirstName = "Sarah", UserLastName = "Oslo", UserJobRole = "Technician", UserEmail = "SarahOslo@gmail.com" },

                // use loop to increment userID? Then it automatically assigns id to new user
            };

        public UserServices()
        {
            // Methods for validation
            public string ValidateEmail(string userEmail)
            {
                if (CheckEmailVaidation(userEmail))
                {
                    return "Email is valid.";
                }
                else
                {
                    return "Email is not valid.";
                }

                static bool CheckEmailVaidation(string userEmail)
                {
                    // Regex pattern to validate email format
                    string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                    return Regex.IsMatch(userEmail, pattern);
                }
            }

            public string ValidatePhoneNumber(string userPhoneNumber)
            {
                if (IsValidPhoneNumber(userPhoneNumber))
                {
                    return "Phone number is valid.";
                }
                else
                {
                    return "Phone number is not valid.";
                }

                static bool IsValidPhoneNumber(string userPhoneNumber)
                {
                    // Regex pattern to validate phone number format
                    string pattern = @"^0\d{9}$";
                    return Regex.IsMatch(UserPhoneNumber, pattern);
                }
            }

            public string ValidateDOB(DateTime userDOB)
            {
                if (IsValidDateOfBirth(userDOB))
                {
                    return "Date of birth is valid.";
                }
                else
                {
                    return "Date of birth is not valid.";
                }
            }

            static bool IsValidDateOfBirth(DateTime userDOB)
            {
                // Regex pattern to validate date of birth format
                string pattern = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{2}$";
                return Regex.IsMatch(userDOB, Convert.ToInt32(pattern));
            }
        }
    }
}

// Methods for CRUD functions in application
