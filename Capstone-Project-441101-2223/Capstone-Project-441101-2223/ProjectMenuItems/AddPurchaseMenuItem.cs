using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class AddPurchaseMenuItem : IMenuItem
    {
        private Project _project;
        public AddPurchaseMenuItem(Project project)
        {
            _project = project;
        }

        public string MenuText()
        {
            return "Purchase";
        }

        public void Select()
        {
            double amount = ConsoleHelpers.GetAmount("Please enter an amount for the purchase");
            _project.AddPurchase("P", amount);
            Console.WriteLine("Purchase of amount " + amount + " added to project " + _project._ID);
        }
    }
}
