namespace EducationForm
{
    partial class MasterSchool
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.eduCityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet5 = new EducationForm.StudentDataSet5();
            this.lblCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.AddSchool = new System.Windows.Forms.Button();
            this.eduCityTableAdapter = new EducationForm.StudentDataSet5TableAdapters.eduCityTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduCityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.ddlCity);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSchool);
            this.panel1.Controls.Add(this.AddSchool);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 352);
            this.panel1.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(117, 44);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(105, 32);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Add School";
            // 
            // ddlCity
            // 
            this.ddlCity.DataSource = this.eduCityBindingSource;
            this.ddlCity.DisplayMember = "CityName";
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(123, 138);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(155, 21);
            this.ddlCity.TabIndex = 7;
            this.ddlCity.ValueMember = "CityName";
            // 
            // eduCityBindingSource
            // 
            this.eduCityBindingSource.DataMember = "eduCity";
            this.eduCityBindingSource.DataSource = this.studentDataSet5;
            // 
            // studentDataSet5
            // 
            this.studentDataSet5.DataSetName = "StudentDataSet5";
            this.studentDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(23, 135);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(77, 25);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "School Name";
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(123, 178);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(155, 20);
            this.txtSchool.TabIndex = 4;
            // 
            // AddSchool
            // 
            this.AddSchool.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSchool.Location = new System.Drawing.Point(99, 239);
            this.AddSchool.Name = "AddSchool";
            this.AddSchool.Size = new System.Drawing.Size(117, 34);
            this.AddSchool.TabIndex = 1;
            this.AddSchool.Text = "Add School";
            this.AddSchool.UseVisualStyleBackColor = true;
            this.AddSchool.Click += new System.EventHandler(this.AddSchool_Click);
            // 
            // eduCityTableAdapter
            // 
            this.eduCityTableAdapter.ClearBeforeFill = true;
            // 
            // MasterSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(370, 376);
            this.Controls.Add(this.panel1);
            this.Name = "MasterSchool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterSchool";
            this.Load += new System.EventHandler(this.MasterSchool_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduCityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Label lblCity;
        private StudentDataSet5 studentDataSet5;
        private System.Windows.Forms.BindingSource eduCityBindingSource;
        private StudentDataSet5TableAdapters.eduCityTableAdapter eduCityTableAdapter;
        private System.Windows.Forms.Label lblHeading;
    }
}