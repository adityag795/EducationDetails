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

    public partial class MasterCollege : Form
    {
        String Cstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection con;
        SqlCommand cmd,cmd2;

        bool ValidateInput()
        {
            if (txtCollege.Text == "")
            {
                MessageBox.Show("Please enter College name");
                txtCollege.Focus();
                return false;
            }
            string val = Convert.ToString(ddlCity.Text);
            if (val == Convert.ToString("-------Select City------"))
            {
                MessageBox.Show("Please Select any State.");
                ddlCity.Focus();
                return false;
            }
            return true;
        }

        public MasterCollege()
        {
            InitializeComponent();
        }

        private void AddCollege_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            
            con = new SqlConnection(Cstring);
            con.Open();
            cmd = new SqlCommand("InsertCollege",con);
            string query = "Select CityID from eduCity where CityName = '" + ddlCity.SelectedValue + "'";
            cmd2 = new SqlCommand(query,con);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CollegeName",txtCollege.Text);
            cmd.Parameters.AddWithValue("@cityId",id);
                
            int rowsAdded = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(rowsAdded.ToString() + " rows added.");
            ddlCity.Text = "-----Select City------";
            txtCollege.Text = "";
        }

        private void MasterCollege_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet12.eduCity' table. You can move, or remove it, as needed.
            this.eduCityTableAdapter.Fill(this.studentDataSet12.eduCity);
            ddlCity.Text = "-------Select City------";

        }
    }
}
