namespace EmployeeManagementApp
{
    partial class Privilage12Form
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
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.RetrieveProjectBtn = new System.Windows.Forms.Button();
            this.ViewAllEmployeesBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Location = new System.Drawing.Point(169, 53);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(189, 40);
            this.AddProjectBtn.TabIndex = 0;
            this.AddProjectBtn.Text = "Add Project";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // RetrieveProjectBtn
            // 
            this.RetrieveProjectBtn.Location = new System.Drawing.Point(169, 128);
            this.RetrieveProjectBtn.Name = "RetrieveProjectBtn";
            this.RetrieveProjectBtn.Size = new System.Drawing.Size(189, 40);
            this.RetrieveProjectBtn.TabIndex = 1;
            this.RetrieveProjectBtn.Text = "Retrieve Project";
            this.RetrieveProjectBtn.UseVisualStyleBackColor = true;
            this.RetrieveProjectBtn.Click += new System.EventHandler(this.RetrieveProjectBtn_Click);
            // 
            // ViewAllEmployeesBtn
            // 
            this.ViewAllEmployeesBtn.Location = new System.Drawing.Point(169, 206);
            this.ViewAllEmployeesBtn.Name = "ViewAllEmployeesBtn";
            this.ViewAllEmployeesBtn.Size = new System.Drawing.Size(189, 40);
            this.ViewAllEmployeesBtn.TabIndex = 2;
            this.ViewAllEmployeesBtn.Text = "View All Employees";
            this.ViewAllEmployeesBtn.UseVisualStyleBackColor = true;
            this.ViewAllEmployeesBtn.Click += new System.EventHandler(this.ViewAllEmployeesBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(169, 292);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(189, 40);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // Privilage12Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.ViewAllEmployeesBtn);
            this.Controls.Add(this.RetrieveProjectBtn);
            this.Controls.Add(this.AddProjectBtn);
            this.Name = "Privilage12Form";
            this.Text = "Provided Functionalities";
            this.Load += new System.EventHandler(this.Privilage12Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddProjectBtn;
        private Button RetrieveProjectBtn;
        private Button ViewAllEmployeesBtn;
        private Button LogOutBtn;
    }
}