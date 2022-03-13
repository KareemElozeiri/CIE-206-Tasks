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
    public partial class ViewAllEmployeesForm : Form
    {
        public ViewAllEmployeesForm()
        {
            InitializeComponent();
            EmployeesDataGrid.Columns.Add("Name", "Name");
            EmployeesDataGrid.Columns.Add("Privilage", "Privilage");
            for (int i = 0; i < Database.CurrentCount; i++) { 
                EmployeesDataGrid.Rows.Add(Database.Users[i].Name,Database.Users[i].Privilage);
            }

        }

        private void EmployeesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
