namespace EducationForm
{
    partial class MasterCollege
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.eduCityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet12 = new EducationForm.StudentDataSet12();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCollege = new System.Windows.Forms.TextBox();
            this.AddCollege = new System.Windows.Forms.Button();
            this.eduCityTableAdapter = new EducationForm.StudentDataSet12TableAdapters.eduCityTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduCityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ddlCity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCollege);
            this.panel1.Controls.Add(this.AddCollege);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 291);
            this.panel1.TabIndex = 1;
            // 
            // ddlCity
            // 
            this.ddlCity.DataSource = this.eduCityBindingSource;
            this.ddlCity.DisplayMember = "CityName";
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(146, 95);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(184, 21);
            this.ddlCity.TabIndex = 0;
            this.ddlCity.Text = "-------Select City------";
            this.ddlCity.ValueMember = "CityName";
            // 
            // eduCityBindingSource
            // 
            this.eduCityBindingSource.DataMember = "eduCity";
            this.eduCityBindingSource.DataSource = this.studentDataSet12;
            // 
            // studentDataSet12
            // 
            this.studentDataSet12.DataSetName = "StudentDataSet12";
            this.studentDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Add College";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "College Name";
            // 
            // txtCollege
            // 
            this.txtCollege.Location = new System.Drawing.Point(146, 144);
            this.txtCollege.Name = "txtCollege";
            this.txtCollege.Size = new System.Drawing.Size(184, 20);
            this.txtCollege.TabIndex = 1;
            // 
            // AddCollege
            // 
            this.AddCollege.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCollege.Location = new System.Drawing.Point(122, 231);
            this.AddCollege.Name = "AddCollege";
            this.AddCollege.Size = new System.Drawing.Size(117, 34);
            this.AddCollege.TabIndex = 1;
            this.AddCollege.Text = "Add College";
            this.AddCollege.UseVisualStyleBackColor = true;
            this.AddCollege.Click += new System.EventHandler(this.AddCollege_Click);
            // 
            // eduCityTableAdapter
            // 
            this.eduCityTableAdapter.ClearBeforeFill = true;
            // 
            // MasterCollege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(374, 313);
            this.Controls.Add(this.panel1);
            this.Name = "MasterCollege";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterCollege";
            this.Load += new System.EventHandler(this.MasterCollege_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduCityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddCollege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCollege;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Label label3;
        private StudentDataSet12 studentDataSet12;
        private System.Windows.Forms.BindingSource eduCityBindingSource;
        private StudentDataSet12TableAdapters.eduCityTableAdapter eduCityTableAdapter;
    }
}