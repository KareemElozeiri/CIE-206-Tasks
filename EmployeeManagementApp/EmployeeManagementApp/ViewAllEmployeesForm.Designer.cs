namespace EmployeeManagementApp
{
    partial class ViewAllEmployeesForm
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
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(-1, 12);
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.RowHeadersWidth = 51;
            this.EmployeesDataGrid.RowTemplate.Height = 29;
            this.EmployeesDataGrid.Size = new System.Drawing.Size(533, 292);
            this.EmployeesDataGrid.TabIndex = 0;
            // 
            // ViewAllEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.EmployeesDataGrid);
            this.Name = "ViewAllEmployeesForm";
            this.Text = "ViewAllEmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView EmployeesDataGrid;
    }
}