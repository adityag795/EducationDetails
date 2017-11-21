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
    public partial class MasterCourse : Form
    {
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlCommand cmd;
        SqlConnection con;

        bool ValidateInput()
        {
            if (txtCourse.Text == "")
            {
                MessageBox.Show("Please enter Course name");
                txtCourse.Focus();
                return false;
            }
            string val = Convert.ToString(txtFees.Text);
            if (val == Convert.ToString(""))
            {
                MessageBox.Show("Please enter fees.");
                txtCourse.Focus();
                return false;
            }
            return true;
        }

        public MasterCourse()
        {
            InitializeComponent();
        }

        public void GridLoad()
        {
            string query = "SELECT * FROM eduCourse";
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            CourseView.DataSource = dt;
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            string query = "INSERT INTO eduCourse (CourseName,CourseFees) VALUES (@a,@b)";
                
            con = new SqlConnection(Cstring);
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@a", txtCourse.Text);
            cmd.Parameters.AddWithValue("@b", txtFees.Text);
            con.Open();
            int rowsAdded = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(rowsAdded.ToString() + " rows added.");
            GridLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridLoad();
        }
      
    }
}
