namespace EmployeeManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Database.x[0].ToString();
            button1.Text = Database.x[2].ToString();
        }
    }
}