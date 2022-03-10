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
    public partial class Privilage12Form : Form
    {
        public Privilage12Form()
        {
            InitializeComponent();
            
        }

        private void Privilage12Form_Load(object sender, EventArgs e)
        {
            if (Database.Users[Database.SelectedUser].Privilage == 1)
            {
                AddProjectBtn.Visible = true;
            }
            else
            {
                AddProjectBtn.Visible = false;
            }
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (new AddProjectForm()).Show();
        }

        private void RetrieveProjectBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (new RetrieveProjectsForm()).Show();
        }

        private void ViewAllEmployeesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (new ViewAllEmployeesForm()).Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginForm()).Show();

       }
        private void Privilage12Form_Closing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }
    }
}
