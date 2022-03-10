namespace EmployeeManagementApp
{
    partial class Privilage3Form
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
            this.AddNewUserBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewUserBtn
            // 
            this.AddNewUserBtn.Location = new System.Drawing.Point(129, 45);
            this.AddNewUserBtn.Name = "AddNewUserBtn";
            this.AddNewUserBtn.Size = new System.Drawing.Size(153, 43);
            this.AddNewUserBtn.TabIndex = 0;
            this.AddNewUserBtn.Text = "Add New User";
            this.AddNewUserBtn.UseVisualStyleBackColor = true;
            this.AddNewUserBtn.Click += new System.EventHandler(this.AddNewUserBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(129, 110);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(153, 43);
            this.LogOutBtn.TabIndex = 1;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // Privilage3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 215);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.AddNewUserBtn);
            this.Name = "Privilage3Form";
            this.Text = "Provided Functionalities";
            this.Load += new System.EventHandler(this.Privilage3Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddNewUserBtn;
        private Button LogOutBtn;
    }
}