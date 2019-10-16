using System;
namespace BeireCooleBitesApi.Models
{
    public class Menu
    {
        public string MenuName { get; set; }
        public  string MenuDescription { get; set; }

        public Menu(string menuName, string menuDescription)
        {
            this.MenuName = menuName;
            this.MenuDescription = menuDescription;
        }
    }
}
