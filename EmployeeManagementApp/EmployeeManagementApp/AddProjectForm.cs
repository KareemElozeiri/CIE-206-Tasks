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
    public partial class AddProjectForm : Form
    {
        public AddProjectForm()
        {
            InitializeComponent();
        }


        private void AddProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            if (ProjectNameTextBox.Text != "" || ProjectLocationTextBox.Text != "" || ProjectNumberTextBox.Text != "") {
                Project p;
                p.Name = ProjectNameTextBox.Text;
                p.Location = ProjectLocationTextBox.Text;
                p.Number = Convert.ToInt32(ProjectNumberTextBox.Text);
                Database.AddProject(p);
                this.Close();
                (new LoginForm()).Show();
            }
        }
    }
}
