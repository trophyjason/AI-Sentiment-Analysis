using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class RemoveProjectMenuItem : IMenuItem
    {
        private Project _project;
        private ProjectManager _manager;
        private ConsoleMenu _menu;

        public RemoveProjectMenuItem(Project project, ProjectManager manager, ConsoleMenu parentItem)
        {
            _project = project;
            _manager = manager;
            _menu = parentItem;
        }

        public string MenuText()
        {
            return "Remove Project " + _project._ID;
        }

        public void Select()
        {
            _manager.RemoveProject(_project);
            Console.WriteLine("Project " + _project._ID + " removed");
            _menu._IsActive = false;
        }
    }
}
