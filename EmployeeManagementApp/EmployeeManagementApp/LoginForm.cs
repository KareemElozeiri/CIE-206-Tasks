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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            User u0 = new User();
            u0.Name = "Kareem";
            u0.Password = "123";
            u0.Privilage = 3;
            Database.AddUser(u0);
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Database.CurrentCount; i++)
            {
                if (UsernameTextBox.Text == Database.Users[i].Name && PassTextBox.Text == Database.Users[i].Password)
                {
                    Database.SelectedUser = i;
                    if (Database.Users[i].Privilage != 3)
                    {
                        Privilage12Form privilage12Form = new Privilage12Form();
                        privilage12Form.Show();
                        this.Hide();
                    }
                    else {
                        Privilage3Form privilage3Form = new Privilage3Form();
                        privilage3Form.Show();
                        this.Hide();
                    }
                }
            }

        }
    }
}
