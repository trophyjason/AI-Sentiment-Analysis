using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class SelectExistingProjectMenu : ConsoleMenu
    {
        private ProjectManager _manager;
        public SelectExistingProjectMenu(ProjectManager manager)
        {
            _manager = manager;
        }

        public override void CreateMenu()
        {
            _menuItems.Clear();
            foreach (Project project in _manager.Projects)
            {
                _menuItems.Add(new SelectedProjectMenu(project, _manager));
            }
            _menuItems.Add(new ExitMenuItem(this));
        }

        public override string MenuText()
        {
            return "Select Existing Project";
        }
    }
}
