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
    public partial class Payment : Form
    {
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString(); 
        SqlConnection con;
        SqlCommand cmd;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet16.StudentInfo' table. You can move, or remove it, as needed.
            this.studentInfoTableAdapter.Fill(this.studentDataSet16.StudentInfo);
            // TODO: This line of code loads data into the 'studentDataSet13.eduCourse' table. You can move, or remove it, as needed.
            this.eduCourseTableAdapter.Fill(this.studentDataSet13.eduCourse);
            ddlStudentId.Text = "-----Select Student Id-----";
        }

        private void ddlStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(Cstring);
            con.Open();
            string query2 = "Select CourseName from StudentInfo where StudentId = " + ddlStudentId.SelectedValue;
            cmd = new SqlCommand(query2, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            //MessageBox.Show(Convert.ToString(rdr["CourseName"]));
            while (rdr.Read())
            {
                txtCourse.Text = Convert.ToString(rdr["CourseName"]);
            }
            rdr.Close();
            string query = "Select CourseFees from eduCourse where CourseName = '" + txtCourse.Text + "'";
            cmd = new SqlCommand(query, con);
            int fees = Convert.ToInt32(cmd.ExecuteScalar());
            lblFees.Text = Convert.ToString(fees);
            double inst = Math.Round(Convert.ToDouble(fees / 3));
            Fee1.Text = Fee2.Text = Fee3.Text = Convert.ToString(inst);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int balFee = 0 ;
            if (checkBox1.Checked == true)
            {
                int fees = Convert.ToInt32(Fee1.Text);
                balFee += fees;
            }
            
            if (checkBox2.Checked == true)
            {
                int fees = Convert.ToInt32(Fee2.Text);
                balFee += fees;
            }
            if (checkBox3.Checked == true)
            {
                int fees = Convert.ToInt32(Fee3.Text);
                balFee += fees;
            }
            textBox1.Text = Convert.ToString(balFee);
        }
    }
}
