namespace EducationForm
{
    partial class Payment
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
            this.btnPayment = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlStudentId = new System.Windows.Forms.ComboBox();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet16 = new EducationForm.StudentDataSet16();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.TotalFees = new System.Windows.Forms.Label();
            this.Fee3 = new System.Windows.Forms.Label();
            this.Fee2 = new System.Windows.Forms.Label();
            this.Fee1 = new System.Windows.Forms.Label();
            this.Inst3 = new System.Windows.Forms.Label();
            this.Inst2 = new System.Windows.Forms.Label();
            this.Inst1 = new System.Windows.Forms.Label();
            this.CourseName = new System.Windows.Forms.Label();
            this.eduCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet13 = new EducationForm.StudentDataSet13();
            this.eduCourseTableAdapter = new EducationForm.StudentDataSet13TableAdapters.eduCourseTableAdapter();
            this.studentInfoTableAdapter = new EducationForm.StudentDataSet16TableAdapters.StudentInfoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ddlStudentId);
            this.panel1.Controls.Add(this.txtCourse);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFees);
            this.panel1.Controls.Add(this.TotalFees);
            this.panel1.Controls.Add(this.Fee3);
            this.panel1.Controls.Add(this.Fee2);
            this.panel1.Controls.Add(this.Fee1);
            this.panel1.Controls.Add(this.Inst3);
            this.panel1.Controls.Add(this.Inst2);
            this.panel1.Controls.Add(this.Inst1);
            this.panel1.Controls.Add(this.CourseName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 408);
            this.panel1.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(263, 252);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 25;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 24;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(279, 211);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 29);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "Paid";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(279, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 29);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Paid";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(279, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 29);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Paid";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Amount to pay";
            // 
            // ddlStudentId
            // 
            this.ddlStudentId.DataSource = this.studentInfoBindingSource;
            this.ddlStudentId.DisplayMember = "StudentId";
            this.ddlStudentId.FormattingEnabled = true;
            this.ddlStudentId.Location = new System.Drawing.Point(130, 60);
            this.ddlStudentId.Name = "ddlStudentId";
            this.ddlStudentId.Size = new System.Drawing.Size(100, 21);
            this.ddlStudentId.TabIndex = 19;
            this.ddlStudentId.ValueMember = "StudentId";
            this.ddlStudentId.SelectedIndexChanged += new System.EventHandler(this.ddlStudentId_SelectedIndexChanged);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentDataSet16;
            // 
            // studentDataSet16
            // 
            this.studentDataSet16.DataSetName = "StudentDataSet16";
            this.studentDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(130, 95);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Student Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Payment Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(136, 251);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(56, 25);
            this.lblFees.TabIndex = 11;
            this.lblFees.Text = "<Fees>";
            // 
            // TotalFees
            // 
            this.TotalFees.AutoSize = true;
            this.TotalFees.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalFees.Location = new System.Drawing.Point(15, 251);
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.Size = new System.Drawing.Size(76, 25);
            this.TotalFees.TabIndex = 9;
            this.TotalFees.Text = "Total Fees";
            // 
            // Fee3
            // 
            this.Fee3.AutoSize = true;
            this.Fee3.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee3.Location = new System.Drawing.Point(148, 206);
            this.Fee3.Name = "Fee3";
            this.Fee3.Size = new System.Drawing.Size(50, 25);
            this.Fee3.TabIndex = 8;
            this.Fee3.Text = "label1";
            // 
            // Fee2
            // 
            this.Fee2.AutoSize = true;
            this.Fee2.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee2.Location = new System.Drawing.Point(148, 168);
            this.Fee2.Name = "Fee2";
            this.Fee2.Size = new System.Drawing.Size(50, 25);
            this.Fee2.TabIndex = 7;
            this.Fee2.Text = "label1";
            // 
            // Fee1
            // 
            this.Fee1.AutoSize = true;
            this.Fee1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fee1.Location = new System.Drawing.Point(148, 130);
            this.Fee1.Name = "Fee1";
            this.Fee1.Size = new System.Drawing.Size(50, 25);
            this.Fee1.TabIndex = 6;
            this.Fee1.Text = "label1";
            // 
            // Inst3
            // 
            this.Inst3.AutoSize = true;
            this.Inst3.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inst3.Location = new System.Drawing.Point(15, 206);
            this.Inst3.Name = "Inst3";
            this.Inst3.Size = new System.Drawing.Size(93, 25);
            this.Inst3.TabIndex = 4;
            this.Inst3.Text = "Installment 3";
            // 
            // Inst2
            // 
            this.Inst2.AutoSize = true;
            this.Inst2.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inst2.Location = new System.Drawing.Point(15, 168);
            this.Inst2.Name = "Inst2";
            this.Inst2.Size = new System.Drawing.Size(93, 25);
            this.Inst2.TabIndex = 3;
            this.Inst2.Text = "Installment 2";
            // 
            // Inst1
            // 
            this.Inst1.AutoSize = true;
            this.Inst1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inst1.Location = new System.Drawing.Point(15, 130);
            this.Inst1.Name = "Inst1";
            this.Inst1.Size = new System.Drawing.Size(93, 25);
            this.Inst1.TabIndex = 2;
            this.Inst1.Text = "Installment 1";
            // 
            // CourseName
            // 
            this.CourseName.AutoSize = true;
            this.CourseName.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.Location = new System.Drawing.Point(15, 90);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(96, 25);
            this.CourseName.TabIndex = 1;
            this.CourseName.Text = "Course Name";
            // 
            // eduCourseBindingSource
            // 
            this.eduCourseBindingSource.DataMember = "eduCourse";
            this.eduCourseBindingSource.DataSource = this.studentDataSet13;
            // 
            // studentDataSet13
            // 
            this.studentDataSet13.DataSetName = "StudentDataSet13";
            this.studentDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eduCourseTableAdapter
            // 
            this.eduCourseTableAdapter.ClearBeforeFill = true;
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(430, 432);
            this.Controls.Add(this.panel1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eduCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Inst3;
        private System.Windows.Forms.Label Inst2;
        private System.Windows.Forms.Label Inst1;
        private System.Windows.Forms.Label CourseName;
        private System.Windows.Forms.Label TotalFees;
        private System.Windows.Forms.Label Fee3;
        private System.Windows.Forms.Label Fee2;
        private System.Windows.Forms.Label Fee1;
        private StudentDataSet13 studentDataSet13;
        private System.Windows.Forms.BindingSource eduCourseBindingSource;
        private StudentDataSet13TableAdapters.eduCourseTableAdapter eduCourseTableAdapter;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlStudentId;
        private StudentDataSet16 studentDataSet16;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentDataSet16TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPayment;
    }
}