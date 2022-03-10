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
    public partial class AddNewUserForm : Form
    {
        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {

        }

        

        private void AddUserBtn_Click_1(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != "" || PasswordTextBox.Text != "" || PrivilageTextBox.Text != "")
            {
                User user = new User();
                user.Name = UsernameTextBox.Text;
                user.Password = PasswordTextBox.Text;
                user.Privilage = Convert.ToInt32(PrivilageTextBox.Text);
                UsernameTextBox.Text = "";
                Database.AddUser(user);
                this.Close();
                (new LoginForm()).Show();
            }
        }
    }
}
