using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class AddNewProjectMenu : ConsoleMenu
    {
        ProjectManager _manager;

        public AddNewProjectMenu(ProjectManager manager)
        {
            _manager = manager;
        }

        public override void CreateMenu()
        {
            _menuItems.Clear();
            _menuItems.Add(new AddNewBuildMenuItem(_manager));
            _menuItems.Add(new AddRenovationMenuItem(_manager));
            _menuItems.Add(new ExitMenuItem(this));
        }

        public override string MenuText()
        {
            return "Add New Project";
        }
    }
}
