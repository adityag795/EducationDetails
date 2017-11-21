using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EducationForm
{
    public partial class StudentDetails : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        public SqlDataReader rdr;
        public int a4;
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
    
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Cstring))
            {
                string query = "select * from StudentInfo where StudentId = " + ddlStudentId.SelectedValue;
                cmd = new SqlCommand(query,con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    MtxtUsername.Text = Convert.ToString(rdr["UserName"]);
                    txtPassword.Text = Convert.ToString(rdr["Password"]);
                    txtFirstName.Text = Convert.ToString(rdr["Fname"]);
                    txtSurName.Text = Convert.ToString(rdr["Sname"]);
                    txtFatherName.Text = Convert.ToString(rdr["DadName"]);
                    txtMotherName.Text = Convert.ToString(rdr["MomName"]);
                    dateTimePicker1.Value = Convert.ToDateTime(rdr["DOB"]);
                    txtMobile.Text = Convert.ToString(rdr["MobNo"]);
                    txtLandline.Text = Convert.ToString(rdr["LandNo"]);
                    txtFees.Text = Convert.ToString(rdr["TotalFees"]);
                
                    txtCurCountry.Text = Convert.ToString(rdr["cCountry"]);
                    txtCurCity.Text = Convert.ToString(rdr["cCity"]);
                    txtCurState.Text = Convert.ToString(rdr["cState"]);
                    txtAddress.Text = Convert.ToString(rdr["cAddress"]);
                    txtPinCode.Text = Convert.ToString(rdr["cPincode"]);

                    txtPerCountry.Text = Convert.ToString(rdr["pCountry"]);
                    txtPerCity.Text = Convert.ToString(rdr["pCity"]);
                    txtPerState.Text = Convert.ToString(rdr["pState"]);
                    txtAddress2.Text = Convert.ToString(rdr["pAddress"]);
                    txtPinCode2.Text = Convert.ToString(rdr["pPincode"]);
    
                    txtCourse.Text = Convert.ToString(rdr["CourseName"]);

                    string gender;
                    gender = Convert.ToString(rdr["Gender"]);
                    if (gender == "M")
                    {
                        Male.Checked = true;
                        Male.Enabled = true;
                    }
                    else
                    {
                        Female.Checked = true;
                        Female.Enabled = true;
                    }

                    StudentPicture.ImageLocation = Convert.ToString(rdr["ImgPath"]);
                }
            }
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet14.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentDataSet14.StudentInfo);
          
            ddlStudentId.Text = "-----Select Student Id-----";
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Update.Enabled = true;
            MtxtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtSurName.ReadOnly = false;
            txtFatherName.ReadOnly = false;
            txtMotherName.ReadOnly = false;
            Male.Enabled = true;
            Female.Enabled = true;
            txtMobile.ReadOnly = false;
            txtLandline.ReadOnly = false;
            txtFees.ReadOnly = false;
            txtCurCountry.ReadOnly = false;
            txtCurCity.ReadOnly = false;
            txtCurState.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPinCode.ReadOnly = false;

            txtPerCountry.ReadOnly = false;
            txtPerCity.ReadOnly = false;
            txtPerState.ReadOnly = false;
            txtAddress2.ReadOnly = false;
            txtPinCode2.ReadOnly = false;
            txtCourse.ReadOnly = false;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Cstring))
            {
                con.Open();
                cmd = new SqlCommand("updateStudentInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                string gender = "";
                if (Male.Checked == true)
                    gender = "M";
                else
                    gender = "F";

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

                cmd.Parameters.AddWithValue("@curCountry", txtCurCountry.Text);
                cmd.Parameters.AddWithValue("@curState", txtCurState.Text);
                cmd.Parameters.AddWithValue("@curCity", txtCurCity.Text);
                cmd.Parameters.AddWithValue("@curAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@curPincode", Convert.ToInt32(txtPinCode.Text));

                cmd.Parameters.AddWithValue("@perCountry", txtPerCountry.Text);
                cmd.Parameters.AddWithValue("@perState", txtPerState.Text);
                cmd.Parameters.AddWithValue("@perCity", txtPerCity.Text);
                cmd.Parameters.AddWithValue("@perAddress", txtAddress2.Text);
                cmd.Parameters.AddWithValue("@perPincode", Convert.ToInt32(txtPinCode2.Text));

                cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                cmd.Parameters.AddWithValue("@total", Convert.ToInt32(txtFees.Text));
                cmd.Parameters.AddWithValue("@studentId", Convert.ToInt32(ddlStudentId.SelectedValue));

                int rowsUpdated = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(rowsUpdated + " rows updated.");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Cstring))
            {
                con.Open();
                int a = studentDataSet14.StudentInfo.Count;
                //string a1 = studentDataSet14.StudentInfo.Rows[0][0].ToString();

                int id = Convert.ToInt32(ddlStudentId.SelectedValue) + 1;

                int a3 = ddlStudentId.SelectedIndex;

                // con.Close();
                int a5 = a3 + 1;
                if (a5 < a)
                {
                    a4 = Convert.ToInt32(studentDataSet14.StudentInfo.Rows[a3 + 1][0]);
                }
                else
                    a4 = a4 + 1;

                    string query = "select * from StudentInfo where StudentId = " + a4;
                    cmd = new SqlCommand(query, con);
                   
                     rdr = cmd.ExecuteReader();
                    // con.Close();
                
             
                if (rdr.HasRows)
                {
                    ddlStudentId.SelectedValue = a4;//Convert.ToInt32(ddlStudentId.SelectedValue) + 1;
                    comboBox1_SelectedIndexChanged(sender, e);
                }
                else
                    MessageBox.Show("No more rows.");
                con.Close();
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Cstring))
            {
                //int id = Convert.ToInt32(ddlStudentId.SelectedValue) - 1;
                //string query = "select * from StudentInfo where StudentId = " + id;
                //cmd = new SqlCommand(query, con);
                con.Open();
                //SqlDataReader rdr = cmd.ExecuteReader();

                //if (rdr.HasRows)
                //{
                //    ddlStudentId.SelectedValue = Convert.ToInt32(ddlStudentId.SelectedValue) - 1;
                //    comboBox1_SelectedIndexChanged(sender, e);
                //}
                //else
                //    MessageBox.Show("No more rows.");
                int ddlItemCount = studentDataSet14.StudentInfo.Count;
                int PreId = Convert.ToInt32(ddlStudentId.SelectedValue) - 1;
                int CurIdIndex = ddlStudentId.SelectedIndex;
                int selectId;
                if (PreId > 0 && CurIdIndex >= 1)
                    selectId = Convert.ToInt32(studentDataSet14.StudentInfo.Rows[CurIdIndex - 1][0]);
                else
                    selectId = CurIdIndex;

                string query = "select * from StudentInfo where StudentId = " + selectId;
                cmd = new SqlCommand(query, con);

                rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    ddlStudentId.SelectedValue = selectId;//Convert.ToInt32(ddlStudentId.SelectedValue) + 1;
                    comboBox1_SelectedIndexChanged(sender, e);
                }
                else
                    MessageBox.Show("No more rows.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(Cstring))
            {
                string query = "delete from StudentInfo where StudentId = " + ddlStudentId.SelectedValue;
                cmd = new SqlCommand(query, con);
                con.Open();
                int delRows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(delRows + " deleted.");
            }
        }


    }
}
