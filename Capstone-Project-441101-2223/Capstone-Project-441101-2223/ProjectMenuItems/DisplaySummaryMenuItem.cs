using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class DisplaySummaryMenuItem : IMenuItem

    {
        private Project _project;
        public DisplaySummaryMenuItem(Project project)
        {
            _project = project;
        }
        public string MenuText()
        {
            return "Display Project Summary";
        }

        public void Select()
        {
            ConsoleHelpers.SummaryHeadings();
            ConsoleHelpers.SummaryFormat(_project._ID.ToString(), _project.TotalSales().ToString("0.00"), _project.TotalPurchases().ToString("0.00"), _project.Refund().ToString("0.00"), _project.Profit().ToString("0.00"));
        }
    }
}
