namespace grocery
{
    struct myItem {
        public string itemName;
        public int itemAmount;
    }
    public partial class Form1 : Form
    {
        private int count;
        private List<myItem> items = new List<myItem>();
        public Form1()
        {
            InitializeComponent();
            ItemsComboBox.Items.Add("Milk");
            ItemsComboBox.Items.Add("Tea");
            ItemsComboBox.Items.Add("Cheese");
            ItemsComboBox.Items.Add("Meat");
            ItemsComboBox.Items.Add("Biscuits");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                myItem item = new myItem();
                
                if (ItemsComboBox.SelectedItem == null) { throw new Exception(message:"Nothing selected from combobox to add"); }
               
                item.itemName = ItemsComboBox.SelectedItem.ToString(); 
                item.itemAmount = Convert.ToInt32(AmountTextBox.Text);
                items.Add(item);
                AmountTextBox.Text = "";
                count++;
            }
            catch (Exception ex) { 
                StatusBar.Text = ex.Message;
            }
        }

        private void ShowItemsButton_Click(object sender, EventArgs e)
        {
            if (ItemsDataGrid.ColumnCount == 0) {
                ItemsDataGrid.Columns.Add("Item", "Item");
                ItemsDataGrid.Columns.Add("Amount", "Amount");
            }
            ItemsDataGrid.Rows.Clear();

            for (int i = 0; i < count; i++) {
                ItemsDataGrid.Rows.Add(items[i].itemName,items[i].itemAmount);
            }
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowNumberButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < count; i++) {
                sum += items[i].itemAmount;
            }
            ShowItemsTextBox.Text = sum.ToString();
        }
    }
}