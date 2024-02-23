namespace UserManagement.Console.Application.Services
{
    public static class MenuItemService
    {
        private static readonly IEnumerable<MenuItem> MenuItems = new List<MenuItem>
        {
            new MenuItem(1, "Add a  new user"),

            new MenuItem(2, "Add a  new job role"),

            new MenuItem(3, "Display all users"),

            new MenuItem(4, "Search for a user"),

            new MenuItem(5, "Update user information"),

            new MenuItem(6, "Delete a user"),

            new MenuItem(7, "Exit"),
        };

        public IEnumerable<MenuItem> DisplayMenuItems()
        {
            return MenuItems;
        }
    }
}
