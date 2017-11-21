namespace EducationForm
{
    partial class MasterState
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
            this.ddlCountry = new System.Windows.Forms.ComboBox();
            this.eduCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet2 = new EducationForm.StudentDataSet2();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.AddState = new System.Windows.Forms.Button();
            this.eduCountryTableAdapter = new EducationForm.StudentDataSet2TableAdapters.eduCountryTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ddlCountry);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.lblCountry);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.txtState);
            this.panel1.Controls.Add(this.AddState);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 324);
            this.panel1.TabIndex = 1;
            // 
            // ddlCountry
            // 
            this.ddlCountry.DataSource = this.eduCountryBindingSource;
            this.ddlCountry.DisplayMember = "CountryName";
            this.ddlCountry.FormattingEnabled = true;
            this.ddlCountry.Location = new System.Drawing.Point(133, 87);
            this.ddlCountry.Name = "ddlCountry";
            this.ddlCountry.Size = new System.Drawing.Size(184, 21);
            this.ddlCountry.TabIndex = 9;
            this.ddlCountry.Text = "-----Select Country-----";
            this.ddlCountry.ValueMember = "CountryName";
            // 
            // eduCountryBindingSource
            // 
            this.eduCountryBindingSource.DataMember = "eduCountry";
            this.eduCountryBindingSource.DataSource = this.studentDataSet2;
            // 
            // studentDataSet2
            // 
            this.studentDataSet2.DataSetName = "StudentDataSet2";
            this.studentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Dubai Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(127, 12);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(100, 34);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Add State";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(27, 87);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(103, 25);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country Name";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(27, 126);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(84, 25);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State Name";
            this.lblState.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(133, 131);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(184, 20);
            this.txtState.TabIndex = 4;
            // 
            // AddState
            // 
            this.AddState.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddState.Location = new System.Drawing.Point(133, 210);
            this.AddState.Name = "AddState";
            this.AddState.Size = new System.Drawing.Size(117, 34);
            this.AddState.TabIndex = 1;
            this.AddState.Text = "Add State";
            this.AddState.UseVisualStyleBackColor = true;
            this.AddState.Click += new System.EventHandler(this.AddState_Click);
            // 
            // eduCountryTableAdapter
            // 
            this.eduCountryTableAdapter.ClearBeforeFill = true;
            // 
            // MasterState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(388, 348);
            this.Controls.Add(this.panel1);
            this.Name = "MasterState";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterState";
            this.Load += new System.EventHandler(this.MasterState_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eduCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox ddlCountry;
        private StudentDataSet2 studentDataSet2;
        private System.Windows.Forms.BindingSource eduCountryBindingSource;
        private StudentDataSet2TableAdapters.eduCountryTableAdapter eduCountryTableAdapter;
    }
}