namespace EducationForm
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.StudentLogin = new System.Windows.Forms.Button();
            this.EmpLogIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.StudentLogin);
            this.panel1.Controls.Add(this.EmpLogIn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 408);
            this.panel1.TabIndex = 3;
            // 
            // StudentLogin
            // 
            this.StudentLogin.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLogin.Location = new System.Drawing.Point(426, 75);
            this.StudentLogin.Name = "StudentLogin";
            this.StudentLogin.Size = new System.Drawing.Size(205, 141);
            this.StudentLogin.TabIndex = 91;
            this.StudentLogin.Text = "Student Login";
            this.StudentLogin.UseVisualStyleBackColor = true;
            // 
            // EmpLogIn
            // 
            this.EmpLogIn.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLogIn.Location = new System.Drawing.Point(153, 75);
            this.EmpLogIn.Name = "EmpLogIn";
            this.EmpLogIn.Size = new System.Drawing.Size(182, 141);
            this.EmpLogIn.TabIndex = 90;
            this.EmpLogIn.Text = "Employee Login";
            this.EmpLogIn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EmpLogIn;
        private System.Windows.Forms.Button StudentLogin;
    }
}