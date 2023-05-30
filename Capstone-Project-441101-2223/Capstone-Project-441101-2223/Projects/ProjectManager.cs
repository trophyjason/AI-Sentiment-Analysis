using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class ProjectManager
    {
        public List<Project> Projects { get; private set; }
        public ProjectManager()
        {
                Projects = new List<Project>();
        }
        
        public void AddProject(Project pProject)
        {
            Projects.Add(pProject);
        }
        public void RemoveProject(Project pProject)
        {
            for (int i = 0; i < Projects.Count; i++)
            {
                if (Projects[i] == pProject)
                {
                    Projects.RemoveAt(i);
                }
            }
        }
        public void PortfolioSummary()
        {
            ConsoleHelpers.SummaryHeadings();
            foreach (Project project in Projects)
            {
                ConsoleHelpers.SummaryFormat(project._ID.ToString(), project.TotalSales().ToString("0.00"), project.TotalPurchases().ToString("0.00"), project.Refund().ToString("0.00"), project.Profit().ToString("0.00"));
            }

            double totalsales1 = 0;
            double totalpurchases1 = 0;
            double totalrefund1 = 0;
            double totalprofit1 = 0;
            foreach (Project project in Projects)
            {
                totalsales1 += project.TotalSales();
                totalpurchases1 += project.TotalPurchases();
                totalrefund1 += project.Refund();
                totalprofit1 += project.Profit();
            }
            ConsoleHelpers.SummaryFormat("All", totalsales1.ToString("0.00"), totalpurchases1.ToString("0.00"), totalrefund1.ToString("0.00"), totalprofit1.ToString("0.00"));
        }
    }
}
