namespace EducationForm
{
    partial class StudentDetails
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
            this.ddlStudentId = new System.Windows.Forms.ComboBox();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet14 = new EducationForm.StudentDataSet14();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Previous = new System.Windows.Forms.Button();
            this.txtPinCode2 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.caPinCode = new System.Windows.Forms.Label();
            this.caAddress = new System.Windows.Forms.Label();
            this.ca = new System.Windows.Forms.Label();
            this.caState = new System.Windows.Forms.Label();
            this.caCountry = new System.Windows.Forms.Label();
            this.txtLandline = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.Landline = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.MtxtUsername = new System.Windows.Forms.MaskedTextBox();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.SurName = new System.Windows.Forms.Label();
            this.FatherName = new System.Windows.Forms.Label();
            this.MotherName = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.CurAdd = new System.Windows.Forms.Label();
            this.StudentPicture = new System.Windows.Forms.PictureBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtCurCity = new System.Windows.Forms.TextBox();
            this.txtCurState = new System.Windows.Forms.TextBox();
            this.txtCurCountry = new System.Windows.Forms.TextBox();
            this.txtPerCity = new System.Windows.Forms.TextBox();
            this.txtPerState = new System.Windows.Forms.TextBox();
            this.txtPerCountry = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.studentInfoTableAdapter = new EducationForm.StudentDataSet14TableAdapters.StudentInfoTableAdapter();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlStudentId
            // 
            this.ddlStudentId.DataSource = this.studentInfoBindingSource;
            this.ddlStudentId.DisplayMember = "StudentId";
            this.ddlStudentId.FormattingEnabled = true;
            this.ddlStudentId.Location = new System.Drawing.Point(144, 71);
            this.ddlStudentId.Name = "ddlStudentId";
            this.ddlStudentId.Size = new System.Drawing.Size(154, 21);
            this.ddlStudentId.TabIndex = 0;
            this.ddlStudentId.ValueMember = "StudentId";
            this.ddlStudentId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "StudentInfo";
            this.studentInfoBindingSource.DataSource = this.studentDataSet14;
            // 
            // studentDataSet14
            // 
            this.studentDataSet14.DataSetName = "StudentDataSet14";
            this.studentDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 25);
            this.label13.TabIndex = 141;
            this.label13.Text = "Total Fees";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 25);
            this.label12.TabIndex = 139;
            this.label12.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 138;
            this.label7.Text = "Permanent Address";
            // 
            // Previous
            // 
            this.Previous.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.Location = new System.Drawing.Point(354, 607);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 31);
            this.Previous.TabIndex = 137;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // txtPinCode2
            // 
            this.txtPinCode2.Location = new System.Drawing.Point(477, 440);
            this.txtPinCode2.Name = "txtPinCode2";
            this.txtPinCode2.ReadOnly = true;
            this.txtPinCode2.Size = new System.Drawing.Size(154, 20);
            this.txtPinCode2.TabIndex = 136;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(477, 415);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(154, 20);
            this.txtAddress2.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 131;
            this.label2.Text = "Pin Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 130;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 129;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 128;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 127;
            this.label6.Text = "Country";
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(477, 264);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.ReadOnly = true;
            this.txtPinCode.Size = new System.Drawing.Size(154, 20);
            this.txtPinCode.TabIndex = 125;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(477, 239);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(154, 20);
            this.txtAddress.TabIndex = 124;
            // 
            // caPinCode
            // 
            this.caPinCode.AutoSize = true;
            this.caPinCode.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caPinCode.Location = new System.Drawing.Point(349, 261);
            this.caPinCode.Name = "caPinCode";
            this.caPinCode.Size = new System.Drawing.Size(68, 25);
            this.caPinCode.TabIndex = 120;
            this.caPinCode.Text = "Pin Code";
            // 
            // caAddress
            // 
            this.caAddress.AutoSize = true;
            this.caAddress.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caAddress.Location = new System.Drawing.Point(349, 236);
            this.caAddress.Name = "caAddress";
            this.caAddress.Size = new System.Drawing.Size(63, 25);
            this.caAddress.TabIndex = 119;
            this.caAddress.Text = "Address";
            // 
            // ca
            // 
            this.ca.AutoSize = true;
            this.ca.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ca.Location = new System.Drawing.Point(349, 211);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(37, 25);
            this.ca.TabIndex = 118;
            this.ca.Text = "City";
            // 
            // caState
            // 
            this.caState.AutoSize = true;
            this.caState.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caState.Location = new System.Drawing.Point(349, 186);
            this.caState.Name = "caState";
            this.caState.Size = new System.Drawing.Size(44, 25);
            this.caState.TabIndex = 117;
            this.caState.Text = "State";
            // 
            // caCountry
            // 
            this.caCountry.AutoSize = true;
            this.caCountry.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caCountry.Location = new System.Drawing.Point(349, 161);
            this.caCountry.Name = "caCountry";
            this.caCountry.Size = new System.Drawing.Size(63, 25);
            this.caCountry.TabIndex = 116;
            this.caCountry.Text = "Country";
            // 
            // txtLandline
            // 
            this.txtLandline.Location = new System.Drawing.Point(144, 405);
            this.txtLandline.Name = "txtLandline";
            this.txtLandline.ReadOnly = true;
            this.txtLandline.Size = new System.Drawing.Size(154, 20);
            this.txtLandline.TabIndex = 173;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(144, 375);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(154, 20);
            this.txtMobile.TabIndex = 172;
            // 
            // Landline
            // 
            this.Landline.AutoSize = true;
            this.Landline.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Landline.Location = new System.Drawing.Point(16, 402);
            this.Landline.Name = "Landline";
            this.Landline.Size = new System.Drawing.Size(121, 25);
            this.Landline.TabIndex = 171;
            this.Landline.Text = "Landline Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 170;
            this.label9.Text = "Mobile Number";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 317);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 169;
            // 
            // MtxtUsername
            // 
            this.MtxtUsername.Location = new System.Drawing.Point(144, 163);
            this.MtxtUsername.Name = "MtxtUsername";
            this.MtxtUsername.ReadOnly = true;
            this.MtxtUsername.Size = new System.Drawing.Size(154, 20);
            this.MtxtUsername.TabIndex = 168;
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(144, 290);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.ReadOnly = true;
            this.txtMotherName.Size = new System.Drawing.Size(154, 20);
            this.txtMotherName.TabIndex = 167;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(144, 265);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.ReadOnly = true;
            this.txtFatherName.Size = new System.Drawing.Size(154, 20);
            this.txtFatherName.TabIndex = 166;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(144, 240);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.ReadOnly = true;
            this.txtSurName.Size = new System.Drawing.Size(154, 20);
            this.txtSurName.TabIndex = 165;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(144, 215);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(154, 20);
            this.txtFirstName.TabIndex = 164;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 190);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(154, 20);
            this.txtPassword.TabIndex = 163;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(16, 212);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(81, 25);
            this.FirstName.TabIndex = 160;
            this.FirstName.Text = "First Name";
            // 
            // SurName
            // 
            this.SurName.AutoSize = true;
            this.SurName.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurName.Location = new System.Drawing.Point(16, 237);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(71, 25);
            this.SurName.TabIndex = 159;
            this.SurName.Text = "SurName";
            // 
            // FatherName
            // 
            this.FatherName.AutoSize = true;
            this.FatherName.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherName.Location = new System.Drawing.Point(16, 262);
            this.FatherName.Name = "FatherName";
            this.FatherName.Size = new System.Drawing.Size(103, 25);
            this.FatherName.TabIndex = 158;
            this.FatherName.Text = "Father\'s Name";
            // 
            // MotherName
            // 
            this.MotherName.AutoSize = true;
            this.MotherName.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherName.Location = new System.Drawing.Point(16, 287);
            this.MotherName.Name = "MotherName";
            this.MotherName.Size = new System.Drawing.Size(108, 25);
            this.MotherName.TabIndex = 157;
            this.MotherName.Text = "Mother\'s Name";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(16, 312);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(92, 25);
            this.DOB.TabIndex = 156;
            this.DOB.Text = "Date of Birth";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(16, 340);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(58, 25);
            this.Gender.TabIndex = 155;
            this.Gender.Text = "Gender";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(16, 187);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(72, 25);
            this.Password.TabIndex = 154;
            this.Password.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(16, 162);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(81, 25);
            this.UserName.TabIndex = 153;
            this.UserName.Text = "User Name";
            // 
            // CurAdd
            // 
            this.CurAdd.AutoSize = true;
            this.CurAdd.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurAdd.Location = new System.Drawing.Point(349, 133);
            this.CurAdd.Name = "CurAdd";
            this.CurAdd.Size = new System.Drawing.Size(115, 25);
            this.CurAdd.TabIndex = 115;
            this.CurAdd.Text = "Current Address";
            // 
            // StudentPicture
            // 
            this.StudentPicture.Location = new System.Drawing.Point(477, 12);
            this.StudentPicture.Name = "StudentPicture";
            this.StudentPicture.Size = new System.Drawing.Size(118, 125);
            this.StudentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentPicture.TabIndex = 174;
            this.StudentPicture.TabStop = false;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(144, 462);
            this.txtFees.Name = "txtFees";
            this.txtFees.ReadOnly = true;
            this.txtFees.Size = new System.Drawing.Size(154, 20);
            this.txtFees.TabIndex = 175;
            // 
            // txtCurCity
            // 
            this.txtCurCity.Location = new System.Drawing.Point(477, 214);
            this.txtCurCity.Name = "txtCurCity";
            this.txtCurCity.ReadOnly = true;
            this.txtCurCity.Size = new System.Drawing.Size(154, 20);
            this.txtCurCity.TabIndex = 176;
            // 
            // txtCurState
            // 
            this.txtCurState.Location = new System.Drawing.Point(477, 190);
            this.txtCurState.Name = "txtCurState";
            this.txtCurState.ReadOnly = true;
            this.txtCurState.Size = new System.Drawing.Size(154, 20);
            this.txtCurState.TabIndex = 177;
            // 
            // txtCurCountry
            // 
            this.txtCurCountry.Location = new System.Drawing.Point(477, 164);
            this.txtCurCountry.Name = "txtCurCountry";
            this.txtCurCountry.ReadOnly = true;
            this.txtCurCountry.Size = new System.Drawing.Size(154, 20);
            this.txtCurCountry.TabIndex = 178;
            // 
            // txtPerCity
            // 
            this.txtPerCity.Location = new System.Drawing.Point(477, 390);
            this.txtPerCity.Name = "txtPerCity";
            this.txtPerCity.ReadOnly = true;
            this.txtPerCity.Size = new System.Drawing.Size(154, 20);
            this.txtPerCity.TabIndex = 179;
            // 
            // txtPerState
            // 
            this.txtPerState.Location = new System.Drawing.Point(477, 365);
            this.txtPerState.Name = "txtPerState";
            this.txtPerState.ReadOnly = true;
            this.txtPerState.Size = new System.Drawing.Size(154, 20);
            this.txtPerState.TabIndex = 180;
            // 
            // txtPerCountry
            // 
            this.txtPerCountry.Location = new System.Drawing.Point(477, 340);
            this.txtPerCountry.Name = "txtPerCountry";
            this.txtPerCountry.ReadOnly = true;
            this.txtPerCountry.Size = new System.Drawing.Size(154, 20);
            this.txtPerCountry.TabIndex = 181;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(477, 466);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(154, 20);
            this.txtCourse.TabIndex = 182;
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(21, 507);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 31);
            this.Edit.TabIndex = 183;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(223, 507);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 31);
            this.Delete.TabIndex = 184;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Enabled = false;
            this.Update.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(122, 507);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 31);
            this.Update.TabIndex = 185;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(556, 607);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 31);
            this.Next.TabIndex = 186;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // studentInfoTableAdapter
            // 
            this.studentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Enabled = false;
            this.Female.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(223, 340);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(75, 29);
            this.Female.TabIndex = 188;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Enabled = false;
            this.Male.Font = new System.Drawing.Font("Dubai Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(144, 340);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(60, 29);
            this.Male.TabIndex = 187;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 662);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtPerCountry);
            this.Controls.Add(this.txtPerState);
            this.Controls.Add(this.txtPerCity);
            this.Controls.Add(this.txtCurCountry);
            this.Controls.Add(this.txtCurState);
            this.Controls.Add(this.txtCurCity);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.StudentPicture);
            this.Controls.Add(this.txtLandline);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.Landline);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MtxtUsername);
            this.Controls.Add(this.txtMotherName);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SurName);
            this.Controls.Add(this.FatherName);
            this.Controls.Add(this.MotherName);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.txtPinCode2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.caPinCode);
            this.Controls.Add(this.caAddress);
            this.Controls.Add(this.ca);
            this.Controls.Add(this.caState);
            this.Controls.Add(this.caCountry);
            this.Controls.Add(this.CurAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlStudentId);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.TextBox txtPinCode2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label caPinCode;
        private System.Windows.Forms.Label caAddress;
        private System.Windows.Forms.Label ca;
        private System.Windows.Forms.Label caState;
        private System.Windows.Forms.Label caCountry;
        private System.Windows.Forms.TextBox txtLandline;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label Landline;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox MtxtUsername;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label SurName;
        private System.Windows.Forms.Label FatherName;
        private System.Windows.Forms.Label MotherName;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label CurAdd;
        private System.Windows.Forms.PictureBox StudentPicture;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtCurCity;
        private System.Windows.Forms.TextBox txtCurState;
        private System.Windows.Forms.TextBox txtCurCountry;
        private System.Windows.Forms.TextBox txtPerCity;
        private System.Windows.Forms.TextBox txtPerState;
        private System.Windows.Forms.TextBox txtPerCountry;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Next;
        private StudentDataSet14 studentDataSet14;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private StudentDataSet14TableAdapters.StudentInfoTableAdapter studentInfoTableAdapter;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
    }
}