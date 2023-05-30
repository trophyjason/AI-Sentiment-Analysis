using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class AddSaleMenuItem : IMenuItem
    {
        private Project _project;
        public AddSaleMenuItem(Project project)
        {
            _project = project;
        }

        public string MenuText()
        {
            return "Sale";
        }

        public void Select()
        {
            double amount = ConsoleHelpers.GetAmount("Please enter an amount for the sale");
            _project.AddSale("S", amount);
            Console.WriteLine("Sale of amount " + amount + " added to project " + _project._ID);
        }
    }
}
