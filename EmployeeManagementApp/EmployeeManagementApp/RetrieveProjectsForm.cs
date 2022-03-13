using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    public partial class RetrieveProjectsForm : Form
    {
        public RetrieveProjectsForm()
        {
           
            InitializeComponent();
            string[] Locations = new string[Database.CurrentCountProjects];
            int LocationsCount = 0;
            for (int i = 0; i < Database.CurrentCountProjects; i++)
            {
                if (!AddedLocation(Locations, LocationsCount, Database.Projects[i]))
                {
                    Locations[LocationsCount] = Database.Projects[i].Location;
                    LocationsCount++;
                }
            }
            for (int i = 0; i < LocationsCount; i++)
            {
                LocationComboBox.Items.Add(Locations[i]);
            }
            ProjectsDataGrid.Columns.Add("Project Name", "Project Name");
            ProjectsDataGrid.Columns.Add("Number", "Number");
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            
            ProjectsDataGrid.Rows.Clear();
            string Location = LocationComboBox.SelectedItem.ToString();
            for (int i = 0; i < Database.CurrentCountProjects; i++) {
                if (Location == Database.Projects[i].Location) { 
                    ProjectsDataGrid.Rows.Add(Database.Projects[i].Name,Database.Projects[i].Number);
                }
            }

        }

        private bool AddedLocation(string[] Locations, int LocationsCount,Project p) {
            for (int i = 0; i < LocationsCount; i++) {
                if (Locations[i] == p.Location) return true;
            }
            return false;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginForm()).Show();
        }
    }
}
