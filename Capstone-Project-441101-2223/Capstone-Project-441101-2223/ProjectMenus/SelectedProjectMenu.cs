using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class SelectedProjectMenu : ConsoleMenu
    {
        private Project _project;
        private ProjectManager _manager;

        public SelectedProjectMenu(Project project, ProjectManager manager)
        {
            _project = project;
            _manager = manager;
        }

        public override void CreateMenu()
        {
            _menuItems.Clear();
            _menuItems.Add(new AddTransactionMenu(_project));
            _menuItems.Add(new DisplaySalesMenuItem(_project));
            _menuItems.Add(new DisplayPurchasesMenuItem(_project));
            _menuItems.Add(new DisplaySummaryMenuItem(_project));
            _menuItems.Add(new RemoveProjectMenuItem(_project, _manager, this));
            _menuItems.Add(new ExitMenuItem(this));
        }

        public override string MenuText()
        {
            return $"Selected Project {_project._ID.ToString()}";
        }
    }
}
