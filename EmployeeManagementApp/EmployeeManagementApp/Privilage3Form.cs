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
    public partial class Privilage3Form : Form
    {
        public Privilage3Form()
        {
            InitializeComponent();
        }

        private void Privilage3Form_Load(object sender, EventArgs e)
        {

        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (new LoginForm()).Show();
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (new AddNewUserForm()).Show();
        }
    }
}
