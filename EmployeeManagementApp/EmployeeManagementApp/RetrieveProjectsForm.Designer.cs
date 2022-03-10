namespace EmployeeManagementApp
{
    partial class RetrieveProjectsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LocationComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // LocationComboBox
            // 
            this.LocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocationComboBox.FormattingEnabled = true;
            this.LocationComboBox.Location = new System.Drawing.Point(244, 40);
            this.LocationComboBox.Name = "LocationComboBox";
            this.LocationComboBox.Size = new System.Drawing.Size(151, 28);
            this.LocationComboBox.TabIndex = 1;
            // 
            // ProjectsDataGrid
            // 
            this.ProjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsDataGrid.Location = new System.Drawing.Point(3, 99);
            this.ProjectsDataGrid.Name = "ProjectsDataGrid";
            this.ProjectsDataGrid.RowHeadersWidth = 51;
            this.ProjectsDataGrid.RowTemplate.Height = 29;
            this.ProjectsDataGrid.Size = new System.Drawing.Size(591, 264);
            this.ProjectsDataGrid.TabIndex = 2;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(244, 398);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(125, 29);
            this.ExecuteBtn.TabIndex = 3;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            // 
            // RetrieveProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.ExecuteBtn);
            this.Controls.Add(this.ProjectsDataGrid);
            this.Controls.Add(this.LocationComboBox);
            this.Controls.Add(this.label1);
            this.Name = "RetrieveProjectsForm";
            this.Text = "RetrieveProjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox LocationComboBox;
        private DataGridView ProjectsDataGrid;
        private Button ExecuteBtn;
    }
}