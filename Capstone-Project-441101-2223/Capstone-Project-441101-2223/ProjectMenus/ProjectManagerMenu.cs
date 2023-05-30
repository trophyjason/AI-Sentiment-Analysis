using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class ProjectManagerMenu : ConsoleMenu
    {
        private ProjectManager _manager;

        public ProjectManagerMenu(ProjectManager manager)
        {
            _manager = manager;
        }

        public override void CreateMenu()
        {
            _menuItems.Clear();
            _menuItems.Add(new AddNewProjectMenu(_manager));
            _menuItems.Add(new LoadTransactionsFromFileMenuItem(_manager));
            if (_manager.Projects.Count > 0)
            {
                _menuItems.Add(new SelectExistingProjectMenu(_manager));
                _menuItems.Add(new ShowPortfolioSummaryMenuItem(_manager));
            }
            _menuItems.Add(new ExitMenuItem(this));
        }

        public override string MenuText()
        {
            return "Project Manager Menu";
        }
    }
}