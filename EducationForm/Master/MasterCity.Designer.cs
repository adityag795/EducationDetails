namespace EducationForm
{
    partial class MasterCity
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
            this.ddlState = new System.Windows.Forms.ComboBox();
            this.eduStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet4 = new EducationForm.StudentDataSet4();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.AddCity = new System.Windows.Forms.Button();
            this.eduStateTableAdapter = new EducationForm.StudentDataSet4TableAdapters.eduStateTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.ddlState);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.AddCity);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 339);
            this.panel1.TabIndex = 1;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Dubai Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(125, 15);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(88, 34);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Add City";
            // 
            // ddlState
            // 
            this.ddlState.DataSource = this.eduStateBindingSource;
            this.ddlState.DisplayMember = "StateName";
            this.ddlState.FormattingEnabled = true;
            this.ddlState.Location = new System.Drawing.Point(120, 119);
            this.ddlState.Name = "ddlState";
            this.ddlState.Size = new System.Drawing.Size(184, 21);
            this.ddlState.TabIndex = 7;
            this.ddlState.Text = "-----Select State-----";
            this.ddlState.ValueMember = "StateName";
            // 
            // eduStateBindingSource
            // 
            this.eduStateBindingSource.DataMember = "eduState";
            this.eduStateBindingSource.DataSource = this.studentDataSet4;
            // 
            // studentDataSet4
            // 
            this.studentDataSet4.DataSetName = "StudentDataSet4";
            this.studentDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "State Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "City Name";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 171);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 20);
            this.txtCity.TabIndex = 4;
            // 
            // AddCity
            // 
            this.AddCity.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCity.Location = new System.Drawing.Point(120, 273);
            this.AddCity.Name = "AddCity";
            this.AddCity.Size = new System.Drawing.Size(117, 34);
            this.AddCity.TabIndex = 1;
            this.AddCity.Text = "Add City";
            this.AddCity.UseVisualStyleBackColor = true;
            this.AddCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // eduStateTableAdapter
            // 
            this.eduStateTableAdapter.ClearBeforeFill = true;
            // 
            // MasterCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(370, 363);
            this.Controls.Add(this.panel1);
            this.Name = "MasterCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterCity";
            this.Load += new System.EventHandler(this.MasterCity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox ddlState;
        private System.Windows.Forms.Label label2;
        private StudentDataSet4 studentDataSet4;
        private System.Windows.Forms.BindingSource eduStateBindingSource;
        private StudentDataSet4TableAdapters.eduStateTableAdapter eduStateTableAdapter;
        private System.Windows.Forms.Label lblHeading;
    }
}