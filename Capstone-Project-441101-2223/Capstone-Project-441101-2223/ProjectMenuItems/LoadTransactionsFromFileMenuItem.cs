using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Project_441101_2223
{
    public class LoadTransactionsFromFileMenuItem : IMenuItem
    {
        //try using wrong files and files with wrong data to test for errors
        //last thing to do
        private ProjectManager _manager;
        public LoadTransactionsFromFileMenuItem(ProjectManager manager)
        {
            _manager = manager;
        }
        public string MenuText()
        {
            return "Load Transactions From File";
        }

        public void Select()
        {
            do
            {
                Console.Write("Please enter the filename of the transactions that you would like to load: ");
                StreamReader reader ;
                string filename;
                try
                {
                
                filename = Console.ReadLine();
                List<string[]> AllValues = new List<string[]>();

                    using (reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Contains('='))
                            {
                                string[] values = line.Split('=');
                                string[] values1 = values[0].Split('(');
                                string[] values2 = values[1].Split(';');
                                string[] values3 = values1[1].Split(")");
                                int id;
                                double amount;

                                bool isTrue = true;
                                try
                                {
                                    id = int.Parse(values3[0].Trim());
                                }
                                catch
                                {
                                    Console.WriteLine("File contains an incorrect ID");
                                    return;
                                }
                                try
                                {
                                    amount = double.Parse(values2[0].Trim());
                                }
                                catch
                                {
                                    Console.WriteLine("File contains a transaction for an ID with an error");
                                    return;
                                }
                                int count = values3[0].Trim().Count();
                                if (count > 3 || count < 3)
                                {
                                    Console.WriteLine("File contains wrong ID size");
                                    return;
                                }
                                string[] newValues = { values1[0], values3[0], values2[0] };
                                AllValues.Add(newValues);

                                if (values1[0] == "Land")
                                {
                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            Console.WriteLine("Error. ID already exists. Exiting File...");
                                            return;
                                        }
                                    }

                                    NewBuild build = new NewBuild(amount, id);
                                    _manager.AddProject(build);
                                    build.AddPurchase("L", amount);
                                }
                                else if (values1[0] == "Renovation")
                                {
                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            Console.WriteLine("Error. ID already exists. Exiting File...");
                                            return;
                                        }
                                    }

                                    Renovation renovation = new Renovation(amount, id);
                                    _manager.AddProject(renovation);
                                    renovation.AddPurchase("R", amount);
                                }
                                else if (values1[0] == "Sale")
                                {
                                    foreach (string[] valuesgroup in AllValues)
                                    {
                                        if (valuesgroup[0] == "Land" && int.Parse(valuesgroup[1]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }
                                        if (valuesgroup[0] == "Renovation" && int.Parse(valuesgroup[1]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }

                                    }
                                    if (isTrue)
                                    {
                                        Console.WriteLine("Error. ID does not have a renovation or build. Exiting File...");
                                        return;
                                    }

                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            project.AddSale("S", amount);
                                        }
                                    }
                                }
                                else if (values1[0] == "Purchase")
                                {
                                    foreach (string[] valuesgroup in AllValues)
                                    {
                                        if (valuesgroup[0] == "Land" && int.Parse(valuesgroup[1]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }
                                        if (valuesgroup[0] == "Renovation" && int.Parse(valuesgroup[1]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }

                                    }
                                    if (isTrue)
                                    {
                                        Console.WriteLine("Error. ID does not have a renovation or build. Exiting File...");
                                        return;
                                    }

                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            project.AddPurchase("P", amount);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("File contains error");
                                    return;
                                }
                            }
                            else
                            {
                                
                                string[] values = line.Split(',');
                                int id;
                                double amount;
                                bool isTrue = true;
                                try
                                {
                                    id = int.Parse(values[0]);
                                }
                                catch
                                {
                                    Console.WriteLine("File contains an incorrect ID");
                                    return;
                                }
                                try
                                {
                                    amount = double.Parse(values[2]);
                                }
                                catch
                                {
                                    Console.WriteLine("File contains a transaction for an ID with an error");
                                    return;
                                }
                                int count = values[0].Count();
                                if (count > 3 || count < 3)
                                {
                                    Console.WriteLine("File contains wrong ID size");
                                    return;
                                }
                                AllValues.Add(values);
                                if (values[1] == "L")
                                {
                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            Console.WriteLine("Error. ID already exists. Exiting File...");
                                            return;
                                        }
                                    }

                                    NewBuild build = new NewBuild(amount,id);
                                    _manager.AddProject(build);
                                    build.AddPurchase("L", amount);
                                }
                                else if (values[1] == "R")
                                {
                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            Console.WriteLine("Error. ID already exists. Exiting File...");
                                            return;
                                        }
                                    }

                                    Renovation renovation = new Renovation(amount,id);
                                    _manager.AddProject(renovation);
                                    renovation.AddPurchase("R", amount);
                                }
                                else if (values[1] == "S")
                                {
                                    foreach (string[] valuesgroup in AllValues)
                                    {
                                        if (valuesgroup[1] == "L" && int.Parse(valuesgroup[0]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }
                                        if (valuesgroup[1] == "R" && int.Parse(valuesgroup[0]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }

                                    }
                                    if (isTrue)
                                    {
                                        Console.WriteLine("Error. ID does not have a renovation or build. Exiting File...");
                                        return;
                                    }

                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            project.AddSale("S", amount);
                                        }
                                    }
                                }
                                else if (values[1] == "P")
                                {
                                    foreach (string[] valuesgroup in AllValues)
                                    {
                                        if (valuesgroup[1] == "L" && int.Parse(valuesgroup[0]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }
                                        if (valuesgroup[1] == "R" && int.Parse(valuesgroup[0]) == id)
                                        {
                                            isTrue = false;
                                            break;
                                        }

                                    }
                                    if (isTrue)
                                    {
                                        Console.WriteLine("Error. ID does not have a renovation or build. Exiting File...");
                                        return;
                                    }

                                    foreach (Project project in _manager.Projects)
                                    {
                                        if (project._ID == id)
                                        {
                                            project.AddPurchase("P", amount);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("File contains error");
                                    return;
                                }
                            }
                        }
                        Console.WriteLine();
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("File does not exist");
                    continue;
                }
            }
            while(true);
        }
    }
}
