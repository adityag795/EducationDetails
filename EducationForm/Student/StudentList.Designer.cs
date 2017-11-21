namespace EducationForm
{
    partial class StudentList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dadNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.momNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPincodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet15 = new EducationForm.StudentDataSet15();
            this.studentInfoTableAdapter = new EducationForm.StudentDataSet15TableAdapters.StudentInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.dadNameDataGridViewTextBoxColumn,
            this.momNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.landNoDataGridViewTextBoxColumn,
            this.cCountryDataGridViewTextBoxColumn,
            this.cStateDataGridViewTextBoxColumn,
            this.cCityDataGridViewTextBoxColumn,
            this.cAddressDataGridViewTextBoxColumn,
            this.cPincodeDataGridViewTextBoxColumn,
            this.pCountryDataGridViewTextBoxColumn,
            this.pStateDataGridViewTextBoxColumn,
            this.pCityDataGridViewTextBoxColumn,
            this.pAddressDataGridViewTextBoxColumn,
            this.pPincodeDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn,
            this.totalFeesDataGridViewTextBoxColumn,
            this.imgPathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1139, 689);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // dadNameDataGridViewTextBoxColumn
            // 
            this.dadNameDataGridViewTextBoxColumn.DataPropertyName = "DadName";
            this.dadNameDataGridViewTextBoxColumn.HeaderText = "DadName";
            this.dadNameDataGridViewTextBoxColumn.Name = "dadNameDataGridViewTextBoxColumn";
            // 
            // momNameDataGridViewTextBoxColumn
            // 
            this.momNameDataGridViewTextBoxColumn.DataPropertyName = "MomName";
            this.momNameDataGridViewTextBoxColumn.HeaderText = "MomName";
            this.momNameDataGridViewTextBoxColumn.Name = "momNameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "MobNo";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "MobNo";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            // 
            // landNoDataGridViewTextBoxColumn
            // 
            this.landNoDataGridViewTextBoxColumn.DataPropertyName = "LandNo";
            this.landNoDataGridViewTextBoxColumn.HeaderText = "LandNo";
            this.landNoDataGridViewTextBoxColumn.Name = "landNoDataGridViewTextBoxColumn";
            // 
            // cCountryDataGridViewTextBoxColumn
            // 
            this.cCountryDataGridViewTextBoxColumn.DataPropertyName = "cCountry";
            this.cCountryDataGridViewTextBoxColumn.HeaderText = "cCountry";
            this.cCountryDataGridViewTextBoxColumn.Name = "cCountryDataGridViewTextBoxColumn";
            // 
            // cStateDataGridViewTextBoxColumn
            // 
            this.cStateDataGridViewTextBoxColumn.DataPropertyName = "cState";
            this.cStateDataGridViewTextBoxColumn.HeaderText = "cState";
            this.cStateDataGridViewTextBoxColumn.Name = "cStateDataGridViewTextBoxColumn";
            // 
            // cCityDataGridViewTextBoxColumn
            // 
            this.cCityDataGridViewTextBoxColumn.DataPropertyName = "cCity";
            this.cCityDataGridViewTextBoxColumn.HeaderText = "cCity";
            this.cCityDataGridViewTextBoxColumn.Name = "cCityDataGridViewTextBoxColumn";
            // 
            // cAddressDataGridViewTextBoxColumn
            // 
            this.cAddressDataGridViewTextBoxColumn.DataPropertyName = "cAddress";
            this.cAddressDataGridViewTextBoxColumn.HeaderText = "cAddress";
            this.cAddressDataGridViewTextBoxColumn.Name = "cAddressDataGridViewTextBoxColumn";
            // 
            // cPincodeDataGridViewTextBoxColumn
            // 
            this.cPincodeDataGridViewTextBoxColumn.DataPropertyName = "cPincode";
            this.cPincodeDataGridViewTextBoxColumn.HeaderText = "cPincode";
            this.cPincodeDataGridViewTextBoxColumn.Name = "cPincodeDataGridViewTextBoxColumn";
            // 
            // pCountryDataGridViewTextBoxColumn
            // 
            this.pCountryDataGridViewTextBoxColumn.DataPropertyName = "pCountry";
            this.pCountryDataGridViewTextBoxColumn.HeaderText = "pCountry";
            this.pCountryDataGridViewTextBoxColumn.Name = "pCountryDataGridViewTextBoxColumn";
            // 
            // pStateDataGridViewTextBoxColumn
            // 
            this.pStateDataGridViewTextBoxColumn.DataPropertyName = "pState";
            this.pStateDataGridViewTextBoxColumn.HeaderText = "pState";
            this.pStateDataGridViewTextBoxColumn.Name = "pStateDataGridViewTextBoxColumn";
            // 
            // pCityDataGridViewTextBoxColumn
            // 
            this.pCityDataGridViewTextBoxColumn.DataPropertyName = "pCity";
            this.pCityDataGridViewTextBoxColumn.HeaderText = "pCity";
            this.pCityDataGridViewTextBoxColumn.Name = "pCityDataGridViewTextBoxColumn";
            // 
            // pAddressDataGridViewTextBoxColumn
            // 
            this.pAddressDataGridViewTextBoxColumn.DataPropertyName = "pAddress";
            this.pAddressDataGridViewTextBoxColumn.HeaderText = "pAddress";
            this.pAddressDataGridViewTextBoxColumn.Name = "pAddressDataGridViewTextBoxColumn";
            // 
            // pPincodeDataGridViewTextBoxColumn
            // 
            this.pPincodeDataGridViewTextBoxColumn.DataPropertyName = "pPincode";
            this.pPincodeDataGridViewTextBoxColumn.HeaderText = "pPincode";
            this.pPincodeDataGridViewTextBoxColumn.Name = "pPincodeDataGridViewTextBoxColumn";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "CourseName";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // totalFeesDataGridViewTextBoxColumn
            // 
            this.totalFeesDataGridViewTextBoxColumn.DataPropertyName = "TotalFees";
            this.totalFeesDataGridViewTextBoxColumn.HeaderText = "TotalFees";
            this.totalFeesDataGridViewTextBoxColumn.Name = "totalFeesDataGridViewTextBoxColumn";
            // 
            // imgPathDataGridViewTextBoxColumn
            // 
            this.imgPathDataGridViewTextBoxColumn.DataPropertyName = "ImgPath";
            this.imgPathDataGridViewTextBoxColumn.HeaderText = "ImgPath";
            this.imgPathDataGridViewTextBoxColumn.Name = "imgPathDataGridViewTextBoxColumn";
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentDataSet15;
            // 
            // studentDataSet15
            // 
            this.studentDataSet15.DataSetName = "StudentDataSet15";
            this.studentDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1163, 713);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentList";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentDataSet15 studentDataSet15;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentDataSet15TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dadNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn momNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn landNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPincodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgPathDataGridViewTextBoxColumn;


    }
}