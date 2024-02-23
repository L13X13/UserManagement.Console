using UserManagement.Console.Application.Services;
using UserManagement.Console.Shared.Models;

public class Program
{
    public static void Main()
    {
        var menuItems = MenuItemService.DisplayMenuItems();

        foreach (var menuItem in menuItems)
        {
            Console.WriteLine(menuItem.ToString);
        }

        // Events after a menu choice  has been made
        int menuChoice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        NextPage(menuChoice);

        // Methods

        // Method reads the user's input, and calls a method relating to the menu ID chosen
        static void NextPage(int menuChoice)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("To display the menu again, enter 7. To exit enter 8.");
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("You have chosen to add a new user.");

                        Console.WriteLine("Enter the user's first name: ");
                        Users.UserFirstName = Console.ReadLine();

                        Console.WriteLine("Enter the user's last name: ");
                        Users.UserLastName = Console.ReadLine();

                        Console.WriteLine("Here is a list of available job roles to choose from: ");
                        JobRoleService.DisplayJobRoles();
                        Console.WriteLine("Enter the user's job role: ");
                        Users.UserJobRole = Console.ReadLine();
                        JobRoleServices.ValidateJobRole();

                        Console.WriteLine("Enter the user's email: ");
                        Users.UserEmail = Console.ReadLine();
                        UserServices.ValidateEmail();

                        Console.WriteLine("Enter the user's phone number: ");
                        Users.UserPhoneNumber = Console.ReadLine();
                        UserServices.ValidatePhoneNumber();

                        Console.WriteLine("Enter the user's date of birth(dd/mm/yy): ");
                        Users.UserDOB = Console.ReadLine();
                        UserServices.ValidateDOB();

                        UserServices.AddNewUser(UserFirstName, UserLastName, UserJobRole, UserEmail, UserPhoneNumber, UserDOB);
                        break;

                    case 2:
                        Console.WriteLine("You have chosen to add a new job role.");

                        Console.WriteLine("Enter the job role name: ");
                        JobRoles.JobRoleName = Console.ReadLine();

                        Console.WriteLine("Enter a description of the job role: ");
                        JobRoles.JobRoleDescription = Console.ReadLine();

                        UserServices.AddJobRole(JobRoleName, JobRoleDesription);
                        JobRoleServices.ValidateJobRole();

                        // Im not sure if this will check that the role has been added or if it already exists but its here now so....
                        break;

                    case 3:
                        Console.WriteLine("You have chosen to display all users.");
                        UserServices.GetUsers();
                        break;

                    case 4:
                        Console.WriteLine("You have chosen to search for a user.");

                        Console.WriteLine("Please enter the user ID that you are looking for: ");

                        string? userId = Console.ReadLine();

                        UserServices.GetUserById();
                        break;

                    case 5:
                        Console.WriteLine("You have chosen to update a user's information.");

                        Console.WriteLine("Please enter the user ID of the user who's information you want to edit: ");
                        userId = Console.ReadLine();

                        Console.WriteLine("Insert the cooresponding number of the item that you would like to update: \n 1. First name \n " +
                            "2. Last name \n 3. Job role \n 4. User email \n 5. User phone number \n 6. User date of birth.");
                        int updateChoice = Convert.ToInt32(Console.ReadLine());

                        switch (UpdateChoice)
                        {
                            case 1:
                                Console.WriteLine("Please enter the name you would like: ");
                                string? changedName = Console.ReadLine();
                                UserServices.UpdateUser(changedName);
                                break;
                            case 2:
                                Console.WriteLine("Please enter the surname you would like: ");
                                string? changedLastname = Console.ReadLine();
                                UserServices.UpdateUser();
                                break;
                            case 3:
                                Console.WriteLine("Please enter the job role you would like: ");
                                string? changedJobRole = Console.ReadLine();
                                JobRoleService.ValidateJobRole(changedJobRole);
                                UserServices.UpdateUser();
                                break;
                            case 4:
                                Console.WriteLine("Please enter the email you would like: ");
                                string? changedEmail = Console.ReadLine();
                                UserServices.ValidateEmail(changedEmail);
                                UserServices.UpdateUser();
                                break;
                            case 5:
                                Console.WriteLine("Please enter the phone number you would like: ");
                                string? changedPhoneNumber = Console.ReadLine();
                                UserServices.ValidatePhoneNumber(changedPhoneNumber);
                                UserServices.UpdateUser();
                                break;
                            case 6:
                                Console.WriteLine("Please enter the date of birth you would like: ");
                                string? changedDOB = Console.ReadLine();
                                UserServices.ValidateDOB(changedDOB);
                                UserServices.UpdateUser();
                                break;
                            default:
                                Console.WriteLine("Please enter one of the available choices...");
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case 6:
                        Console.WriteLine("You have chosen to delete a user.");

                        Console.WriteLine("Please enter the user ID of the user who's information you want to delete: ");
                        userId = Console.ReadLine();

                        UserServices.DeleteUserById();
                        break;

                    case 7:
                        Console.WriteLine("You have chosen to display the menu again");
                        Console.Clear();
                        MenuItemService.DisplayMenuItes();
                        break;

                    case 8:
                        Console.WriteLine("You have chosen to exit. Goodbye");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Please select one of the menu options");
                        MenuItemService.DisplayMenuItems();
                        continue;
                }
            }
            while (exit == false);
        }
    }
}