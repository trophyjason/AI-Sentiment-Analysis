using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class ShowPortfolioSummaryMenuItem : IMenuItem
    {
        private ProjectManager _manager;
        public ShowPortfolioSummaryMenuItem(ProjectManager manager)
        {
            _manager = manager;
        }

        public string MenuText()
        {
            return "Show Portfolio Summary";
        }

        public void Select()
        {
            _manager.PortfolioSummary();
        }
    }
}
