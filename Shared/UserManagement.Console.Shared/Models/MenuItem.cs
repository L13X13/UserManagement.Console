﻿namespace UserManagement.Console.Shared.Models
{
  /// <summary>
  /// The Menu Item class.
  /// </summary>
  /// <remarks>
  /// Tip: Use LINQ to get and validate the menu the selected item.
  /// </remarks>
  public class MenuItem
  {
        public MenuItem(int menuItemId, string menuItemDescription)
        {
            this.MenuItemId = menuItemId;
            this.MenuItemDescription = menuItemDescription;
        }

    /// <summary>
    /// Gets or sets the Menu Item Id.
    /// </summary>
    /// <remarks>
    /// You need to generate the menu item id.
    /// </remarks>
        public int MenuItemId { get; set; }

        public string MenuItemDescription { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{this.MenuItemId}. {this.MenuItemDescription}";
        }
    }
}
