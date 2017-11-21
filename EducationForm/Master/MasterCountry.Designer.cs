namespace EducationForm
{
    partial class MasterCountry
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eduCountryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new EducationForm.StudentDataSet1();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.AddCountry = new System.Windows.Forms.Button();
            this.eduCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new EducationForm.StudentDataSet();
            this.eduCountryTableAdapter = new EducationForm.StudentDataSetTableAdapters.eduCountryTableAdapter();
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eduCountryTableAdapter1 = new EducationForm.StudentDataSet1TableAdapters.eduCountryTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduCountryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Country);
            this.panel1.Controls.Add(this.AddCountry);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 237);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryIDDataGridViewTextBoxColumn,
            this.countryNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eduCountryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(247, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.HeaderText = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            this.countryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryNameDataGridViewTextBoxColumn
            // 
            this.countryNameDataGridViewTextBoxColumn.DataPropertyName = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.HeaderText = "CountryName";
            this.countryNameDataGridViewTextBoxColumn.Name = "countryNameDataGridViewTextBoxColumn";
            // 
            // eduCountryBindingSource1
            // 
            this.eduCountryBindingSource1.DataMember = "eduCountry";
            this.eduCountryBindingSource1.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(160, 92);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 34);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Country Name";
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(38, 45);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(184, 20);
            this.Country.TabIndex = 4;
            // 
            // AddCountry
            // 
            this.AddCountry.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCountry.Location = new System.Drawing.Point(19, 92);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(117, 34);
            this.AddCountry.TabIndex = 1;
            this.AddCountry.Text = "Add Country";
            this.AddCountry.UseVisualStyleBackColor = true;
            this.AddCountry.Click += new System.EventHandler(this.AddCountry_Click);
            // 
            // eduCountryBindingSource
            // 
            this.eduCountryBindingSource.DataMember = "eduCountry";
            this.eduCountryBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eduCountryTableAdapter
            // 
            this.eduCountryTableAdapter.ClearBeforeFill = true;
            // 
            // studentDataSetBindingSource
            // 
            this.studentDataSetBindingSource.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource.Position = 0;
            // 
            // eduCountryTableAdapter1
            // 
            this.eduCountryTableAdapter1.ClearBeforeFill = true;
            // 
            // MasterCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(577, 259);
            this.Controls.Add(this.panel1);
            this.Name = "MasterCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterCountry";
            this.Load += new System.EventHandler(this.MasterCountry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduCountryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource eduCountryBindingSource;
        private StudentDataSetTableAdapters.eduCountryTableAdapter eduCountryTableAdapter;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource eduCountryBindingSource1;
        private StudentDataSet1TableAdapters.eduCountryTableAdapter eduCountryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryNameDataGridViewTextBoxColumn;
    }
}