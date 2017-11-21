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
    public partial class MasterSchool : Form
    {
        String CString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection con;
        SqlCommand cmd,cmd2;

        bool ValidateInput()
        {
            if (ddlCity.Text == "-----Select City-----")
            {    
                MessageBox.Show("Please select any city.");
                return false;
            }
            if (txtSchool.Text == "")
            {
                MessageBox.Show("Please enter school name.");
                return false;
            }
            return true;
        }
        public MasterSchool()
        {
            InitializeComponent();
        }

        private void AddSchool_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            con = new SqlConnection(CString);
            con.Open();

            string query = "select CityID from eduCity where CityName = '" + ddlCity.SelectedValue + "'";
            cmd2 = new SqlCommand(query, con);
            int id = Convert.ToInt32(cmd2.ExecuteScalar());
            cmd = new SqlCommand("InsertSchool", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SchoolName", ddlCity.SelectedValue);
            cmd.Parameters.AddWithValue("@cityId", id);

            int rowsAdded = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(rowsAdded.ToString() + " added.");
        }

        private void MasterSchool_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet5.eduCity' table. You can move, or remove it, as needed.
            this.eduCityTableAdapter.Fill(this.studentDataSet5.eduCity);
            ddlCity.Text = "-----Select City-----";
        }
       
    }
}
