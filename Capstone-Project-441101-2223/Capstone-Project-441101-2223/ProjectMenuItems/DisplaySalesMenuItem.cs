using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class DisplaySalesMenuItem : IMenuItem
    {
        private Project _project;
        public DisplaySalesMenuItem(Project project)
        {
            _project = project;
        }
        public string MenuText()
        {
            return "Display Project Sales";
        }

        public void Select()
        {
            ConsoleHelpers.TransactionHeadings();
            foreach (KeyValuePair<string, double> pair in _project._Sales)
            {
                ConsoleHelpers.TransactionFormat(pair.Key, pair.Value.ToString("0.00"));
            }
        }
    }
}
