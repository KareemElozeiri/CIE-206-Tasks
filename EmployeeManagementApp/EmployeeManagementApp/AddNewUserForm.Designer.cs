namespace EmployeeManagementApp
{
    partial class AddNewUserForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PrivilageTextBox = new System.Windows.Forms.TextBox();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Privilage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(215, 58);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(170, 27);
            this.UsernameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(215, 127);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(170, 27);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // PrivilageTextBox
            // 
            this.PrivilageTextBox.Location = new System.Drawing.Point(215, 194);
            this.PrivilageTextBox.Name = "PrivilageTextBox";
            this.PrivilageTextBox.Size = new System.Drawing.Size(170, 27);
            this.PrivilageTextBox.TabIndex = 5;
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Location = new System.Drawing.Point(161, 254);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(110, 36);
            this.AddProjectBtn.TabIndex = 6;
            this.AddProjectBtn.Text = "Add";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 317);
            this.Controls.Add(this.AddProjectBtn);
            this.Controls.Add(this.PrivilageTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private TextBox PrivilageTextBox;
        private Button AddProjectBtn;
    }
}