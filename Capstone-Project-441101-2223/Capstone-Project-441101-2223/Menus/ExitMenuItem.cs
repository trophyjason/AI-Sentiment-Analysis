using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    class ExitMenuItem : IMenuItem
    {
        private ConsoleMenu _menu;

        public ExitMenuItem(ConsoleMenu parentItem)
        {
            _menu = parentItem;
        }

        public string MenuText()
        {
            return "Exit";
        }

        public void Select()
        {
            _menu._IsActive = false;
        }
    }
}
