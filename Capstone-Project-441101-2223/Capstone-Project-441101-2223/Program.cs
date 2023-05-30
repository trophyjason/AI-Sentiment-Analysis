// See https://aka.ms/new-console-template for more information
using Capstone_Project_441101_2223;

Console.WriteLine("Hello, Capstone!");

ProjectManager manager = new ProjectManager();

new ProjectManagerMenu(manager).Select();