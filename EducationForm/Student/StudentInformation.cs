using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace EducationForm
{
    public partial class StudentInfo : Form
    {
        String CString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection con;
        SqlCommand cmd;

        bool ValidateInput()
        {
            if ((Male.Checked == false) && (Female.Checked == false))
            {
                MessageBox.Show("Please select any gender.");
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("Please enter Mobile Number.");
                txtMobile.Focus();
                return false;
            }
            if (MtxtUsername.Text == "")
            {
                MessageBox.Show("Please enter user name");
                MtxtUsername.Focus();
                return false;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password");
                txtPassword.Focus();
                return false;
            }
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter first name");
                txtFirstName.Focus();
                return false;
            }
            if (txtSurName.Text == "")
            {
                MessageBox.Show("Please enter Sur name");
                txtSurName.Focus();
                return false;
            }
            if (txtFatherName.Text == "")
            {
                MessageBox.Show("Please enter Father's name");
                txtFatherName.Focus();
                return false;
            }
            if (txtMotherName.Text == "")
            {
                MessageBox.Show("Please enter Mother's name");
                txtMotherName.Focus();
                return false;
            }
            if (txtMobile.Text == "")
            {
                MessageBox.Show("Please enter Mobile Number");
                txtMobile.Focus();
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter Address");
                txtAddress.Focus();
                return false;
            }
            if (txtPinCode.Text == "")
            {
                MessageBox.Show("Please enter Pin Code");
                txtPinCode.Focus();
                return false;
            }
            if (txtAddress2.Text == "")
            {
                MessageBox.Show("Please enter Address in Permanent Address.");
                txtAddress2.Focus();
                return false;
            }
            if (txtPinCode2.Text == "")
            {
                MessageBox.Show("Please enter Pin Code in Permanent Address.");
                txtPinCode2.Focus();
                return false;
            }
            if (label9.Text == "")
            {
                MessageBox.Show("Please upload your photo.");
                return false;
            }
            // Drop Downs

            string val = Convert.ToString(ddlState.Text);
            if (val == Convert.ToString("-----Select State-----"))
            {
                MessageBox.Show("Please Select any State.");
                ddlState.Focus();
                return false;
            }
            val = Convert.ToString(ddlCountry.Text);
            if (val == Convert.ToString("-----Select Country-----"))
            {
                MessageBox.Show("Please Select any Country.");
                ddlCountry.Focus();
                return false;
            }
            val = Convert.ToString(ddlCity.Text);
            if (val == Convert.ToString("-----Select City-----"))
            {
                MessageBox.Show("Please Select any City.");
                ddlCity.Focus();
                return false;
            }
            val = Convert.ToString(ddlCountry2.Text);
            if (val == Convert.ToString("-----Select Country-----"))
            {
                MessageBox.Show("Please Select any Country in Permanent Address.");
                ddlCountry2.Focus();
                return false;
            }
            val = Convert.ToString(ddlCity2.Text);
            if (val == Convert.ToString("-----Select City-----"))
            {
                MessageBox.Show("Please Select any City in Permanent Address.");
                ddlCity2.Focus();
                return false;
            }
            val = Convert.ToString(ddlState2.Text);
            if (val == Convert.ToString("-----Select State-----"))
            {
                MessageBox.Show("Please Select any State in Permanent Address.");
                ddlState2.Focus();
                return false;
            }
            val = Convert.ToString(ddlCourse.Text);
            if (val == Convert.ToString("-----Select Course-----"))
            {
                MessageBox.Show("Please Select any Course.");
                ddlCourse.Focus();
                return false;
            }

            // Check for picture
            if (label9.Text == "")
            {
                MessageBox.Show("Please choose a file path.");
                return false;
            }
            return true;
        }


        public StudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet11.eduCity' table. You can move, or remove it, as needed.
            this.eduCityTableAdapter1.Fill(this.studentDataSet11.eduCity);
            // TODO: This line of code loads data into the 'studentDataSet10.eduState' table. You can move, or remove it, as needed.
            this.eduStateTableAdapter1.Fill(this.studentDataSet10.eduState);
            // TODO: This line of code loads data into the 'studentDataSet9.eduCountry' table. You can move, or remove it, as needed.
            this.eduCountryTableAdapter1.Fill(this.studentDataSet9.eduCountry);
            // TODO: This line of code loads data into the 'studentDataSet8.eduCity' table. You can move, or remove it, as needed.
            this.eduCityTableAdapter.Fill(this.studentDataSet8.eduCity);
            // TODO: This line of code loads data into the 'studentDataSet7.eduState' table. You can move, or remove it, as needed.
            this.eduStateTableAdapter.Fill(this.studentDataSet7.eduState);
            // TODO: This line of code loads data into the 'studentDataSet6.eduCountry' table. You can move, or remove it, as needed.
            this.eduCountryTableAdapter.Fill(this.studentDataSet6.eduCountry);
            // TODO: This line of code loads data into the 'studentDataSet3.eduCourse' table. You can move, or remove it, as needed.
            this.eduCourseTableAdapter.Fill(this.studentDataSet3.eduCourse);
            ddlCity.Text = "-----Select City-----";
            ddlCity2.Text = "-----Select City-----";
            ddlState.Text = "-----Select State-----";
            ddlState2.Text = "-----Select State-----";
            ddlCountry.Text = "-----Select Country-----";
            ddlCountry2.Text = "-----Select Country-----";
            ddlCourse.Text = "-----Select Course-----";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog odialog = new OpenFileDialog();
            //odialog.Filter = "";
            if (odialog.ShowDialog()==DialogResult.OK )            
            {
                StudentPicture.Image = new Bitmap(odialog.FileName);
                label9.Text = odialog.FileName;
                //PictureBox p1 = new PictureBox();
                //Bitmap img = new Bitmap(label9.Text);
                //p1.Image = (img);
                //p1.Dock = DockStyle.Fill;
                //p1.Image = (Image)img;
                Image img = Bitmap.FromFile(odialog.FileName);
                StudentPicture.Image = img;
            }
            else
            {
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            using (con = new SqlConnection(CString))
            {
                con.Open();
                string gender = "";
                if (Male.Checked == true)
                    gender = "M";
                else
                    gender = "F";
                cmd = new SqlCommand("spStudentInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usname", MtxtUsername.Text);
                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@sname", txtSurName.Text);
                cmd.Parameters.AddWithValue("@dad", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@mom", txtMotherName.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@mob", txtMobile.Text);
                cmd.Parameters.AddWithValue("@land", txtLandline.Text);
                
                cmd.Parameters.AddWithValue("@curCountry", ddlCountry.Text);
                cmd.Parameters.AddWithValue("@curState", ddlState.Text);
                cmd.Parameters.AddWithValue("@curCity", ddlCity.Text);
                cmd.Parameters.AddWithValue("@curAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@curPincode", Convert.ToInt32(txtPinCode.Text));

                cmd.Parameters.AddWithValue("@perCountry", ddlCountry2.Text);
                cmd.Parameters.AddWithValue("@perState", ddlState2.Text);
                cmd.Parameters.AddWithValue("@perCity", ddlCity2.Text);
                cmd.Parameters.AddWithValue("@perAddress", txtAddress2.Text);
                cmd.Parameters.AddWithValue("@perPincode", Convert.ToInt32(txtPinCode2.Text));

                cmd.Parameters.AddWithValue("@Course", ddlCourse.SelectedValue);
                cmd.Parameters.AddWithValue("@total", Convert.ToInt32(lblFees.Text));
                cmd.Parameters.AddWithValue("@img", label9.Text);
                
                // Output parameter
                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@studentId";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                int rowsAdded = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(rowsAdded + " rows added.");
            }
        }

        private void Same_CheckedChanged(object sender, EventArgs e)
        {
            if (Same.Checked == true)
            {
                ddlCountry2.SelectedValue = ddlCountry.SelectedValue;
                ddlState2.SelectedValue = ddlState.SelectedValue;
                ddlCity2.SelectedValue = ddlCity.SelectedValue;
                txtPinCode2.Text = txtPinCode.Text;
                txtAddress2.Text = txtAddress.Text;
            }
        }

        private void ddlCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(CString);
            con.Open();
            string query = "Select CourseFees from eduCourse where CourseName = '" + ddlCourse.SelectedValue + "'";
            cmd = new SqlCommand(query, con);
            int fees = Convert.ToInt32(cmd.ExecuteScalar());
            lblFees.Text = Convert.ToString(fees);
        }
        
    }
}
