using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class AddTransactionMenu : ConsoleMenu
    {
        private Project _project;
        public AddTransactionMenu(Project project)
        {
            _project = project;
        }
        public override void CreateMenu()
        {
            _menuItems.Clear();
            _menuItems.Add(new AddPurchaseMenuItem(_project));
            _menuItems.Add(new AddSaleMenuItem(_project));
            _menuItems.Add(new ExitMenuItem(this));
        }

        public override string MenuText()
        {
            return "Add Transaction To Project";
        }
    }
}
