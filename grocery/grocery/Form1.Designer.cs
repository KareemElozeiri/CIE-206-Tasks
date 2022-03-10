namespace grocery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ItemsComboBox = new System.Windows.Forms.ComboBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowItemsButton = new System.Windows.Forms.Button();
            this.ItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.ShowNumberButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowItemsTextBox = new System.Windows.Forms.TextBox();
            this.StatusBar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(12, 32);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(76, 35);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(12, 80);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(104, 35);
            this.AmountLabel.TabIndex = 1;
            this.AmountLabel.Text = "Amount";
            // 
            // ItemsComboBox
            // 
            this.ItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsComboBox.FormattingEnabled = true;
            this.ItemsComboBox.Location = new System.Drawing.Point(161, 41);
            this.ItemsComboBox.Name = "ItemsComboBox";
            this.ItemsComboBox.Size = new System.Drawing.Size(151, 28);
            this.ItemsComboBox.TabIndex = 2;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(161, 89);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(151, 27);
            this.AmountTextBox.TabIndex = 3;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(488, 41);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowItemsButton
            // 
            this.ShowItemsButton.Location = new System.Drawing.Point(488, 89);
            this.ShowItemsButton.Name = "ShowItemsButton";
            this.ShowItemsButton.Size = new System.Drawing.Size(94, 29);
            this.ShowItemsButton.TabIndex = 5;
            this.ShowItemsButton.Text = "Show Items";
            this.ShowItemsButton.UseVisualStyleBackColor = true;
            this.ShowItemsButton.Click += new System.EventHandler(this.ShowItemsButton_Click);
            // 
            // ItemsDataGrid
            // 
            this.ItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGrid.Location = new System.Drawing.Point(12, 144);
            this.ItemsDataGrid.Name = "ItemsDataGrid";
            this.ItemsDataGrid.RowHeadersWidth = 51;
            this.ItemsDataGrid.RowTemplate.Height = 29;
            this.ItemsDataGrid.Size = new System.Drawing.Size(570, 188);
            this.ItemsDataGrid.TabIndex = 6;
            // 
            // ShowNumberButton
            // 
            this.ShowNumberButton.Location = new System.Drawing.Point(22, 358);
            this.ShowNumberButton.Name = "ShowNumberButton";
            this.ShowNumberButton.Size = new System.Drawing.Size(195, 65);
            this.ShowNumberButton.TabIndex = 7;
            this.ShowNumberButton.Text = "Show Number of Items In Order";
            this.ShowNumberButton.UseVisualStyleBackColor = true;
            this.ShowNumberButton.Click += new System.EventHandler(this.ShowNumberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of items";
            // 
            // ShowItemsTextBox
            // 
            this.ShowItemsTextBox.Location = new System.Drawing.Point(461, 377);
            this.ShowItemsTextBox.Name = "ShowItemsTextBox";
            this.ShowItemsTextBox.ReadOnly = true;
            this.ShowItemsTextBox.Size = new System.Drawing.Size(125, 27);
            this.ShowItemsTextBox.TabIndex = 9;
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(277, 421);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.ReadOnly = true;
            this.StatusBar.Size = new System.Drawing.Size(309, 27);
            this.StatusBar.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.ShowItemsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowNumberButton);
            this.Controls.Add(this.ItemsDataGrid);
            this.Controls.Add(this.ShowItemsButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ItemsComboBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ItemsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ItemsLabel;
        private Label AmountLabel;
        private ComboBox ItemsComboBox;
        private TextBox AmountTextBox;
        private Button AddButton;
        private Button ShowItemsButton;
        private DataGridView ItemsDataGrid;
        private Button ShowNumberButton;
        private Label label1;
        private TextBox ShowItemsTextBox;
        private TextBox StatusBar;
    }
}