using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    internal class Database
    {
       
        public static int MaxCount = 100;
        public static int CurrentCount = 0;
        public static int SelectedUser = -1;
        public static User[] Users = new User[MaxCount];
        public static Project[] Projects = new Project[MaxCount];
        public static int CurrentCountProjects = 0;

        public static void AddProject(Project project) {
            Projects[CurrentCountProjects] = project;
            CurrentCountProjects++;
        }

        public static void AddUser(User user) { 
            Users[CurrentCount] = user;
            CurrentCount++;
        }
    }
}
