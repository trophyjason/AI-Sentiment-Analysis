using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class AddNewBuildMenuItem : IMenuItem
    {
        private ProjectManager _manager;
        public AddNewBuildMenuItem(ProjectManager manager)
        {
            _manager = manager;
        }

        public string MenuText()
        {
            return "New Build";
        }

        public void Select()
        {
            double amount = ConsoleHelpers.GetAmount("Please enter amount for the land purchase");
            NewBuild build = new NewBuild(amount);
            _manager.AddProject(build);
            build.AddPurchase("L", amount);
            Console.WriteLine("Project created with ID " + build._ID);
        }
    }
}
