using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class AddRenovationMenuItem : IMenuItem
    {
        private ProjectManager _manager;
        public AddRenovationMenuItem(ProjectManager manager)
        {
            _manager = manager;
        }

        public string MenuText()
        {
            return "Renovation";
        }

        public void Select()
        {
            double amount = ConsoleHelpers.GetAmount("Please enter amount for the building purchase");
            Renovation renovation = new Renovation(amount);
            _manager.AddProject(renovation);
            renovation.AddPurchase("R", amount);
            Console.WriteLine("Project created with ID " + renovation._ID);
        }
    }
}
